using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00B.Composites;

namespace underware.Edifact.D00B.Segments
{
    public class FII : Segment
    {
        public FII() : base("FII", "Financial institution information") { }

        [ElementInfo(0, "Party function code qualifier", "M", "1", "an..3", "")]
        public string E3035 { get; set; }
        [ElementInfo(1, "ACCOUNT HOLDER IDENTIFICATION", "C", "1", "", "")]
        public C078 C078 { get; set; }
        [ElementInfo(2, "INSTITUTION IDENTIFICATION", "C", "1", "", "")]
        public C088 C088 { get; set; }
        [ElementInfo(3, "Country name code", "C", "1", "an..3", "")]
        public string E3207 { get; set; }


    }
}