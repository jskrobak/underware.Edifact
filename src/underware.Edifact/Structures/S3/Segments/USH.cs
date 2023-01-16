using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.Common.Interfaces;
using underware.Edifact.Structures.S3.Composites;

namespace underware.Edifact.Structures.S3.Segments
{
    public class USH : Segment, IUSH
    {
        public USH() : base("USH", "Security header") { }
        public USH(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "", "M", "1", "an..3", "")]
        public string E0552 { get; set; }

        [ElementInfo(1, "Security service, coded", "M", "1", "an..3", "")]
        public string E0501 { get; set; }
        
        [ElementInfo(2, "Security reference number", "M", "1", "an..14", "")]
        public string E0534 { get; set; }

        [ElementInfo(3, "Scope of security application, coded", "C", "1", "an..3", "")]
        public string E0541 { get; set; }

        [ElementInfo(4, "Response type, coded", "C", "1", "an..3", "")]
        public string E0503 { get; set; }

        [ElementInfo(5, "Filter function, coded", "C", "1", "an..3", "")]
        public string E0505 { get; set; }

        [ElementInfo(6, "Original character set encoding, coded", "C", "1", "an..3", "")]
        public string E0507 { get; set; }

        [ElementInfo(7, "Role of security provider, coded", "C", "1", "an..3", "")]
        public string E0509 { get; set; }

        [ElementInfo(8, "SECURITY IDENTIFICATION DETAILS", "C", "2", "", "")]
        public S500 S500 { get; set; }

        [ElementInfo(9, "SECURITY IDENTIFICATION DETAILS", "C", "2", "", "")]
        public S500 S500_0 { get; set; }

        [ElementInfo(10, "Security sequence number", "C", "1", "an..35", "")]
        public string E0516 { get; set; }

        [ElementInfo(11, "SECURITY DATE AND TIME", "C", "1", "", "")]
        public S501 S501 { get; set; }

        public DateTime Date => DateTime.ParseExact(string.Concat(S501.E0338, S501.E0314), "yyyyMMddHHmmss", CultureInfo.InvariantCulture);

        public int Filter => int.Parse(E0505);
    }
}