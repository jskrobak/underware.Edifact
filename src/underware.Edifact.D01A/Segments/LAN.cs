using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01A.Composites;

namespace underware.Edifact.D01A.Segments
{
    public class LAN : Segment
    {
        public LAN() : base("LAN", "Language") { }

        [ElementInfo(0, "Language code qualifier", "M", "1", "an..3", "")]
        public string E3455 { get; set; }
        [ElementInfo(1, "LANGUAGE DETAILS", "C", "1", "", "")]
        public C508 C508 { get; set; }


    }
}