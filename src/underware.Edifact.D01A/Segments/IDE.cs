using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01A.Composites;

namespace underware.Edifact.D01A.Segments
{
    public class IDE : Segment
    {
        public IDE() : base("IDE", "Identity") { }

        [ElementInfo(0, "Object type code qualifier", "M", "1", "an..3", "")]
        public string E7495 { get; set; }
        [ElementInfo(1, "IDENTIFICATION NUMBER", "C", "1", "", "")]
        public C206 C206 { get; set; }
        [ElementInfo(2, "PARTY IDENTIFICATION DETAILS", "C", "1", "", "")]
        public C082 C082 { get; set; }
        [ElementInfo(3, "Status description code", "C", "1", "an..3", "")]
        public string E4405 { get; set; }
        [ElementInfo(4, "Configuration level number", "C", "1", "n..2", "")]
        public string E1222 { get; set; }
        [ElementInfo(5, "POSITION IDENTIFICATION", "C", "99", "", "")]
        public C778 C778 { get; set; }
        [ElementInfo(6, "PRODUCT CHARACTERISTIC", "C", "1", "", "")]
        public C240 C240 { get; set; }


    }
}