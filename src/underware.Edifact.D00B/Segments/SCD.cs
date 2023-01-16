using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00B.Composites;

namespace underware.Edifact.D00B.Segments
{
    public class SCD : Segment
    {
        public SCD() : base("SCD", "Structure component definition") { }

        [ElementInfo(0, "Structure component function code qualifier", "M", "1", "an..3", "")]
        public string E7497 { get; set; }
        [ElementInfo(1, "STRUCTURE COMPONENT IDENTIFICATION", "C", "1", "", "")]
        public C786 C786 { get; set; }
        [ElementInfo(2, "PARTY IDENTIFICATION DETAILS", "C", "1", "", "")]
        public C082 C082 { get; set; }
        [ElementInfo(3, "Status description code", "C", "1", "an..3", "")]
        public string E4405 { get; set; }
        [ElementInfo(4, "Configuration level number", "C", "1", "n..2", "")]
        public string E1222 { get; set; }
        [ElementInfo(5, "POSITION IDENTIFICATION", "C", "1", "", "")]
        public C778 C778 { get; set; }
        [ElementInfo(6, "PRODUCT CHARACTERISTIC", "C", "1", "", "")]
        public C240 C240 { get; set; }


    }
}