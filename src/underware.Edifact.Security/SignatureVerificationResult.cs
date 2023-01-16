using System;
using System.Collections.Generic;
using System.Text;

namespace underware.Edifact.Security
{
    public class SignatureVerificationResult
    {
        public string InterchangeRefNo { get; set; }
        public string MessageRefNo { get; set; }
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
