using System;
using System.Collections.Generic;
using System.Text;

namespace underware.Edifact.Security
{
    public class SignatureVerificationResult(SignatureInfo signature)
    {
        public DateTime Created { get; } = DateTime.Now;
        public SignatureInfo Signature { get; set; } = signature;
        
        public bool IsSignatureValid { get; set; }
        public string CertStatus { get; set; }
        public byte[] SignedDataSHA1Hash { get; set; }

        public int AutackCode
        {
            get
            {
                if (CertStatus != "")
                    return 2;
                else if (!IsSignatureValid)
                    return 1;
                else
                    return 0;
            }
        }
    }
}
