using Org.BouncyCastle.Crypto;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using bccX509 = Org.BouncyCastle.X509;
using System.Linq;
using System.Globalization;
using System.Numerics;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Pkcs;
using System.IO;
using System.Security.Cryptography;
using underware.Edifact.Structures.Common.Interfaces;

namespace underware.Edifact.Security
{
    public static class Extensions
    {
        public static void Sign(this Interchange itr, Encoding enc, string pfxFile, string pfxPassword,
            HashAlgorithm hashAlgorithm = HashAlgorithm.SHA256)
        {
            bccX509.X509Certificate cert = null;
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

        public static void Sign(this Interchange itr, Encoding enc, bccX509.X509Certificate cert,
            ICipherParameters privateKey, HashAlgorithm hashAlgorithm = HashAlgorithm.SHA256)
        {
            Signer signer = itr.Syntax.Version switch
            {
                3 => new Signers.S3Signer(),
                4 => new Signers.S4Signer(),
                _ => throw new NotSupportedException(
                    $"Syntax {itr.Syntax.ToString()} is not supported")
            };

            foreach (var msg in itr.Messages)
                signer.SignMessage(msg, enc, hashAlgorithm, cert, privateKey);
        }

        public static BigInteger ToBigInteger(this string text)
        {
            return BigInteger.Parse(text, NumberStyles.HexNumber);
        }


        public static SignatureInfo GetSignatureInfo(this Message msg)
        {
            if (msg.Interchange == null)
                throw new ArgumentNullException(nameof(msg));

            if (!msg.IsSigned())
                throw new InvalidOperationException("Message is not signed");
            
            var segmentsToRemove = new string[] { "UNH", "UST", "USR", "UNT" };

            var signedSegments = msg.AllSegments.Where(s => !segmentsToRemove.Contains(s.Name))
                .Select(se => se.ToString());
            var signedString = msg.Interchange.CharSpec.JoinSegments(signedSegments);

            var ush = (IUSH)msg.AllSegments.First(s => s.Name == "USH");
            var usr = (IUSR)msg.AllSegments.Last(s => s.Name == "USR");
            var usa = (IUSA)msg.AllSegments.First(s => s.Name == "USA");
            var usc = (IUSC)msg.AllSegments.First(s => s.Name == "USC");

            var info = new SignatureInfo
            {
                InterchangeRefNo = msg.Interchange.RefNo,
                MessageRefNo = msg.UNH.MessageReferenceNumber,
                SignedString = $"{signedString}{msg.Interchange.CharSpec.SegmentSeparator}",
                CertSn = usc.CertSn,
                SignatureFilter = ush.Filter,
                SignatureString = usr.Signature,
                Date = ush.Date,
                HashAlgorithm = usa.HashAlgorithm
            };

            return info;
        }

        public static string FormatProperties(this object si)
        {
            return string.Join(
                Environment.NewLine,
                si.GetType().GetProperties()
                    .Select(p => $"{p.Name}: {p.GetValue(si)}"));
        }

        public static bool IsSigned(this Message msg)
        {
            return msg.AllSegments.Exists(s => s.Name == "USH") && msg.AllSegments.Exists(s => s.Name == "USR");
        }

        public static SignatureVerificationResult VerifySignature(this SignatureInfo info, Encoding enc,
            X509Certificate2Collection allCerts, bool ignoreUntrustedRoot = false)
        {

            var result = new SignatureVerificationResult(info);
            
            X509Certificate2 cert = null;

            foreach (var c in from c in allCerts
                     let sn = BigInteger.Parse(c.SerialNumber, System.Globalization.NumberStyles.HexNumber)
                     where sn == info.CertSn.ToBigInteger()
                     select c)
            {
                cert = c;
            }

            if (cert == null)
            {
                result.CertStatus = "CERTIFICATE NOT FOUND";
                result.IsSignatureValid = false;
                return result;
            }


            //test certificate
            var ch = new X509Chain();

            ch.ChainPolicy.ExtraStore.AddRange(allCerts);
            ch.ChainPolicy.VerificationTime = info.Date;
            ch.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
            var chainValid = ch.Build(cert);
            
            var isOnlyUntrustedRoot = ch.ChainStatus.All(
                s => s.Status == X509ChainStatusFlags.UntrustedRoot);

            result.CertStatus = (!chainValid && isOnlyUntrustedRoot && ignoreUntrustedRoot) 
                ? ""
                : string.Join(", ", ch.ChainStatus.Select(s => s.Status.ToString()));

            var signature = Filter.GetFilter(info.SignatureFilter).Decode(info.SignatureString);
            var signedData = Encoding.Convert(Encoding.UTF8, enc, Encoding.UTF8.GetBytes(info.SignedString));

            //string sd = Convert.ToBase64String(signedData);
            //byte[] hash = System.Security.Cryptography.HashAlgorithm.Create(_hashAlgorithm).ComputeHash(signedData);
            result.SignedDataSHA1Hash = SHA1.HashData(signedData);

            //string ss = Convert.ToBase64String(result.SignedDataSHA1Hash);

            var bcCert = new bccX509.X509CertificateParser().ReadCertificate(cert.RawData);

            var verifier = SignerUtilities.GetSigner((HashAlgorithm)info.HashAlgorithm + "WithRSA");

            verifier.Init(false, bcCert.GetPublicKey());
            verifier.BlockUpdate(signedData, 0, signedData.Length);
            result.IsSignatureValid = verifier.VerifySignature(signature);


            return result;
        }

        public static string ToHexString(this byte[] b)
        {
            return Convert.ToHexString(b);
        } 

    }


}
