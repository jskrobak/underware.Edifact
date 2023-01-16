using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class PIA : Segment
    {
        public PIA() : base("PIA", "Additional product id") { }

        [ElementInfo(0, "Product identifier code qualifier", "M", "1", "an..3", "")]
        public string E4347 { get; set; }
        [ElementInfo(1, "ITEM NUMBER IDENTIFICATION", "M", "1", "", "")]
        public C212 C212 { get; set; }
        [ElementInfo(2, "ITEM NUMBER IDENTIFICATION", "C", "1", "", "")]
        public C212 C212_0 { get; set; }
        [ElementInfo(3, "ITEM NUMBER IDENTIFICATION", "C", "1", "", "")]
        public C212 C212_1 { get; set; }
        [ElementInfo(4, "ITEM NUMBER IDENTIFICATION", "C", "1", "", "")]
        public C212 C212_2 { get; set; }
        [ElementInfo(5, "ITEM NUMBER IDENTIFICATION", "C", "1", "", "")]
        public C212 C212_3 { get; set; }


    }
}