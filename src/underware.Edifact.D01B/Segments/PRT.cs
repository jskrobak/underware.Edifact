using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class PRT : Segment
    {
        public PRT() : base("PRT", "Party information") { }

        [ElementInfo(0, "Party function code qualifier", "M", "1", "an..3", "")]
        public string E3035 { get; set; }
        [ElementInfo(1, "OBJECT IDENTIFICATION", "C", "9", "", "")]
        public E206 E206 { get; set; }
        [ElementInfo(2, "Date value", "C", "3", "an..14", "")]
        public string E2000 { get; set; }
        [ElementInfo(3, "PARTY DEMOGRAPHIC INFORMATION", "C", "1", "", "")]
        public E023 E023 { get; set; }


    }
}