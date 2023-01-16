using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using bccX509 = Org.BouncyCastle.X509;
using System.Linq;
using System.Globalization;
using System.Numerics;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Pkcs;
using System.IO;
using underware.Edifact.Structures.Common.Interfaces;
using s3 = underware.Edifact.Structures.S3;
using d94a = underware.Edifact.D94A;

namespace underware.Edifact.Security
{
    public static class Extensions
    {
        public static void Sign(this Interchange itr, Encoding enc, string pfxFile, string pfxPassword, HashAlgorithm hashAlgorithm = HashAlgorithm.SHA256)
        {
            Org.BouncyCastle.X509.X509Certificate cert = null;
            ICipherParameters privateKey = null;
            Pkcs12Store pk12 = null;

            pk12 = new Pkcs12Store(new FileStream(pfxFile, FileMode.Open, FileAccess.Read), pfxPassword.ToCharArray());

            string alias = null;

            X509CertificateEntry entry = null;

            //Iterate throught certificate entries to find the private key entry
            foreach (string a in pk12.Aliases)
            {
                alias = a;
                entry = pk12.GetCertificate(a);

                if (pk12.IsKeyEntry(alias))
                    break;
            }

            cert = entry.Certificate;
            privateKey = pk12.GetKey(alias).Key;

            Sign(itr, enc, cert, privateKey, hashAlgorithm);
        }

        public static void Sign(this Interchange itr, Encoding enc, bccX509.X509Certificate cert, ICipherParameters privateKey, HashAlgorithm hashAlgorithm = HashAlgorithm.SHA256)
        {
            Signer signer = null;

            if (itr.Syntax.Version == 3)
                signer = (Signer)new Signers.S3Signer();
            else if (itr.Syntax.Version == 4)
                signer = (Signer)new Signers.S4Signer();
            else
                throw new NotSupportedException(string.Format("Syntax {0} is not supported", itr.Syntax.ToString()));

            foreach (Message msg in itr.Messages)
                signer.SignMessage(msg, enc, hashAlgorithm, cert, privateKey);
        }

        public static BigInteger ToBigInteger(this string text)
        {
            return BigInteger.Parse(text, NumberStyles.HexNumber);
        }


        public static SignatureInfo SignatureInfo(this Message msg)
        {
            if (msg.Interchange == null)
                throw new ArgumentNullException("Message has to be part of an interchnange");


            SignatureInfo info = new SignatureInfo();

            string[] segmentsToRemove = new string[] { "UNH", "UST", "USR", "UNT" };

            var signedSegments = msg.AllSegments.Where(s => !segmentsToRemove.Contains(s.Name)).Select(se => se.ToString());
            string signedString = msg.Interchange.CharSpec.JoinSegments(signedSegments);
            info.SignedString = string.Format("{0}{1}", signedString, msg.Interchange.CharSpec.SegmentSeparator);

            IUSH ush = (IUSH)msg.AllSegments.Where(s => s.Name == "USH").First();
            IUSR usr = (IUSR)msg.AllSegments.Where(s => s.Name == "USR").Last();
            IUSA usa = (IUSA)msg.AllSegments.Where(s => s.Name == "USA").First();
            IUSC usc = (IUSC)msg.AllSegments.Where(s => s.Name == "USC").First();

            info.CertSn = usc.CertSn;
            info.SignatureFilter = ush.Filter;
            info.SignatureString = usr.Signature;
            info.Date = ush.Date;
            info.HashAlgorithm = usa.HashAlgorithm;

            return info;
        }

        public static bool IsSigned(this Message msg)
        {
            return msg.AllSegments.Exists(s => s.Name == "USH") && msg.AllSegments.Exists(s => s.Name == "USR");
        }

        public static SignatureVerificationResult VerifySignature(this SignatureInfo info, Encoding enc, X509Certificate2Collection allCerts)
        {
            SignatureVerificationResult result = new SignatureVerificationResult();

            X509Certificate2 cert = null;

            foreach (X509Certificate2 c in allCerts)
            {
                BigInteger sn = BigInteger.Parse(c.SerialNumber, System.Globalization.NumberStyles.HexNumber);
                if (sn == info.CertSn.ToBigInteger())
                    cert = c;
            }

            if (cert != null)
            {
                //test certificate
                X509Chain ch = new X509Chain();

                ch.ChainPolicy.ExtraStore.AddRange(allCerts);
                ch.ChainPolicy.VerificationTime = info.Date;
                ch.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
                ch.Build(cert);

                result.CertStatus = string.Join(", ", ch.ChainStatus.Select(s => s.Status.ToString()));

                byte[] signature = Filter.GetFilter(info.SignatureFilter).Decode(info.SignatureString);
                byte[] signedData = Encoding.Convert(Encoding.UTF8, enc, Encoding.UTF8.GetBytes(info.SignedString));

                //string sd = Convert.ToBase64String(signedData);
                //byte[] hash = System.Security.Cryptography.HashAlgorithm.Create(_hashAlgorithm).ComputeHash(signedData);
                result.SignedDataSHA1Hash = System.Security.Cryptography.HashAlgorithm.Create("SHA1").ComputeHash(signedData);

                //string ss = Convert.ToBase64String(result.SignedDataSHA1Hash);

                Org.BouncyCastle.X509.X509Certificate bcCert = new Org.BouncyCastle.X509.X509CertificateParser().ReadCertificate(cert.RawData);

                ISigner verifier = SignerUtilities.GetSigner((HashAlgorithm)info.HashAlgorithm + "WithRSA");

                verifier.Init(false, bcCert.GetPublicKey());
                verifier.BlockUpdate(signedData, 0, signedData.Length);
                result.IsSignatureValid = verifier.VerifySignature(signature);
            }
            else
            {
                result.CertStatus = "CERTIFICATE NOT FOUND";
                result.IsSignatureValid = false;
            }


            return result;
        }

        

        public static Interchange VerifyAndCreate_AUTACK_D94A(this Interchange itr, Encoding enc, X509Certificate2Collection allCerts, string autackRefNo)
        {
            Interchange autackItr = new Interchange(CharSpec.Default, Syntax.UNOD3, itr.UNB.Receiver, itr.UNB.Sender, autackRefNo, "AUTACK", false);

            int cnt = 1;
            foreach (var msg in itr.Messages)
            {
                string msgRefNo = string.Format("{0}{1:0000}", autackRefNo, cnt);
                var signature = msg.SignatureInfo();
                var result = signature.VerifySignature(enc, allCerts);

                DateTime now = DateTime.Now;

                var autack = new D94A.Messages.AUTACK();
                autack.Segments.Add(new s3.Segments.USH("USH+94W+5+00++{0}+2", signature.SignatureFilter));
                autack.Segments.Add(new d94a.Segments.USB("USB+1+1:{0:yyyyMMdd}:{0:HHmmss}+{1}+{2}", now, itr.UNB.Sender, itr.UNB.Receiver));
                autack.Segments.Add(new s3.Segments.USY("USY+01+{0}+{1}", result.SignedDataSHA1Hash.ToHexString(), result.AutackCode));
                autack.Segments.Add(new s3.Segments.USX("USX+{0}+++++{1}++5:{2:yyyyMMdd}:{2:HHmmss}:{3}", itr.UNB.RefNo, msgRefNo, now, now.SummerWinter()));

                autackItr.Messages.Add(autack);
            }

            return autackItr;
        }

        public static string ToHexString(this byte[] b)
        {
            return BitConverter.ToString(b).Replace("-", "");
        } 

    }


}
