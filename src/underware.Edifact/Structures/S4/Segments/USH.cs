using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.Common.Interfaces;
using underware.Edifact.Structures.S4.Composites;

namespace underware.Edifact.Structures.S4.Segments
{
    public class USH : Segment, IUSH
    {
        public USH() : base("USH", "Security header") { }
        public USH(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Security service, coded", "M", "1", "an..3", "")]
        public string E0501 { get; set; }
        [ElementInfo(1, "Security reference number", "M", "1", "an..14", "")]
        public string E0534 { get; set; }
        [ElementInfo(2, "Scope of security application, coded", "C", "1", "an..3", "")]
        public string E0541 { get; set; }
        [ElementInfo(3, "Response type, coded", "C", "1", "an..3", "")]
        public string E0503 { get; set; }
        [ElementInfo(4, "Filter function, coded", "C", "1", "an..3", "")]
        public string E0505 { get; set; }
        [ElementInfo(5, "Original character set encoding, coded", "C", "1", "an..3", "")]
        public string E0507 { get; set; }
        [ElementInfo(6, "Role of security provider, coded", "C", "1", "an..3", "")]
        public string E0509 { get; set; }
        [ElementInfo(7, "SECURITY IDENTIFICATION DETAILS", "C", "2", "", "")]
        public S500 S500 { get; set; }
        [ElementInfo(8, "Security sequence number", "C", "1", "an..35", "")]
        public string E0520 { get; set; }
        [ElementInfo(9, "SECURITY DATE AND TIME", "C", "1", "", "")]
        public S501 S501 { get; set; }

        public DateTime Date => DateTime.ParseExact(string.Concat(S501.E0517, S501.E0338), "yyyyMMddHHmmss", CultureInfo.InvariantCulture);

        public int Filter => int.Parse(E0505);

    }
}