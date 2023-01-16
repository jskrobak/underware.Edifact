using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class RCS : Segment
    {
        public RCS() : base("RCS", "Requirements and conditions") { }

        [ElementInfo(0, "Sector area identification code qualifier", "M", "1", "an..3", "")]
        public string E7293 { get; set; }
        [ElementInfo(1, "REQUIREMENT/CONDITION IDENTIFICATION", "C", "1", "", "")]
        public C550 C550 { get; set; }
        [ElementInfo(2, "Action request/notification description code", "C", "1", "an..3", "")]
        public string E1229 { get; set; }
        [ElementInfo(3, "Country name code", "C", "1", "an..3", "")]
        public string E3207 { get; set; }


    }
}