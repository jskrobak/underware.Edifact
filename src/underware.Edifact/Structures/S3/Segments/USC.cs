using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.Common.Interfaces;
using underware.Edifact.Structures.S3.Composites;

namespace underware.Edifact.Structures.S3.Segments
{
    public class USC : Segment, IUSC
    {
        public USC() : base("USC", "Certificate") { }
        public USC(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Certificate reference", "C", "1", "an..35", "")]
        public string E0536 { get; set; }
        [ElementInfo(1, "SECURITY IDENTIFICATION DETAILS", "C", "2", "", "")]
        public S500 S500 { get; set; }
        [ElementInfo(2, "Certificate syntax and version, coded", "C", "1", "an..3", "")]
        public string E0545 { get; set; }
        [ElementInfo(3, "Filter function, coded", "C", "1", "an..3", "")]
        public string E0505 { get; set; }
        [ElementInfo(4, "Original character set encoding, coded", "C", "1", "an..3", "")]
        public string E0507 { get; set; }
        [ElementInfo(5, "Certificate original character set repertoire, coded", "C", "1", "an..3", "")]
        public string E0543 { get; set; }
        [ElementInfo(6, "User authorisation level", "C", "1", "an..35", "")]
        public string E0546 { get; set; }
        [ElementInfo(7, "SERVICE CHARACTER FOR SIGNATURE", "C", "5", "", "")]
        public S505 S505 { get; set; }
        [ElementInfo(8, "SECURITY DATE AND TIME", "C", "4", "", "")]
        public S501 S501 { get; set; }
        [ElementInfo(9, "Security status, coded", "C", "1", "an..3", "")]
        public string E0567 { get; set; }
        [ElementInfo(10, "Revocation reason, coded", "C", "1", "an..3", "")]
        public string E0569 { get; set; }

        public string CertSn => E0536;
    }
}