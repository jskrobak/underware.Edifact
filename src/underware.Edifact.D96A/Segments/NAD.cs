using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D96A.Composites;
using underware.Edifact.Structures.Common.Segments.Interfaces;

namespace underware.Edifact.D96A.Segments
{
    public class NAD : Segment, INAD
    {
        public NAD() : base("NAD", "Name and address") { }

        [ElementInfo(0, "Party qualifier", "M", "1", "an..3", "")]
        public string E3035 { get; set; }
        [ElementInfo(1, "PARTY IDENTIFICATION DETAILS", "C", "1", "", "")]
        public C082 C082 { get; set; }
        [ElementInfo(2, "NAME AND ADDRESS", "C", "1", "", "")]
        public C058 C058 { get; set; }
        [ElementInfo(3, "PARTY NAME", "C", "1", "", "")]
        public C080 C080 { get; set; }
        [ElementInfo(4, "STREET", "C", "1", "", "")]
        public C059 C059 { get; set; }
        [ElementInfo(5, "City name", "C", "1", "an..35", "")]
        public string E3164 { get; set; }
        [ElementInfo(6, "Country sub-entity identification", "C", "1", "an..9", "")]
        public string E3229 { get; set; }
        [ElementInfo(7, "Postcode identification", "C", "1", "an..9", "")]
        public string E3251 { get; set; }
        [ElementInfo(8, "Country, coded", "C", "1", "an..3", "")]
        public string E3207 { get; set; }

        public string Qualifier => E3035;

        public string Identifier => C082.E3039;

        public string PartyName => string.Concat(C080.E3036, C080.E3036_0, C080.E3036_1, C080.E3036_2, C080.E3036_2, C080.E3036_3);
    }
}