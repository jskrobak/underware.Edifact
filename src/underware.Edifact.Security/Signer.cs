using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using bccX509 = Org.BouncyCastle.X509;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Linq;

namespace underware.Edifact.Security
{
    public abstract class Signer
    {
        public virtual void SignMessage(Message msg, Encoding enc, HashAlgorithm hashAlgorithm, bccX509.X509Certificate cert, ICipherParameters privateKey)
        {
            AddSecurityHeader(msg, hashAlgorithm, cert);
            byte[] signature = CreateSignature(msg, enc, hashAlgorithm, privateKey);
            AddSecurityTrailer(msg, signature);
        }

        public virtual byte[] CreateSignature(Message msg, Encoding enc, HashAlgorithm hashAlgorithm, ICipherParameters privateKey)
        {
            CharSpec chars = msg.Interchange.CharSpec;

            string stringToSign = string.Concat(chars.JoinSegments(msg.AllSegments.GetRange(1, msg.AllSegments.Count - 2)), chars.SegmentSeparator);
            //string stringToSign = string.Format("{0}{1}", chars.JoinSegments(msg.GetRange(1, msg.Count - 2)), chars.SegmentSeparator);

            byte[] dataToSignUTF8 = Encoding.UTF8.GetBytes(stringToSign);
            byte[] dataToSign = Encoding.Convert(Encoding.UTF8, enc, dataToSignUTF8);

            ISigner signer = SignerUtilities.GetSigner(string.Format("{0}WithRSA", hashAlgorithm));

            signer.Init(true, privateKey);
            signer.BlockUpdate(dataToSign, 0, dataToSign.Length);
            byte[] signatureData = signer.GenerateSignature();


            string d = Convert.ToBase64String(dataToSign);
            string ssss = Convert.ToBase64String(signatureData);

            string ss = Convert.ToBase64String(System.Security.Cryptography.HashAlgorithm.Create("SHA1").ComputeHash(dataToSign));

            return signatureData;
        }

        public abstract void AddSecurityHeader(Message msg, HashAlgorithm hashAlgorithm, bccX509.X509Certificate cert);
        public abstract void AddSecurityTrailer(Message msg, byte[] signature);
        public abstract Filter Filter { get; }
    }
}
