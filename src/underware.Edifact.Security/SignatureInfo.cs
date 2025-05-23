using System;
using System.Collections.Generic;
using System.Text;

namespace underware.Edifact.Security
{
    public class SignatureInfo
    {
        public string CertSn { get; set; }
        public string SignedString { get; set; }
        public int SignatureFilter { get; set; }
        public string SignatureString { get; set; }
        public DateTime Date { get; set; }
        public int HashAlgorithm { get; set; }
        public string InterchangeRefNo { get; set; }
        public string MessageRefNo { get; set; }
    }
}
