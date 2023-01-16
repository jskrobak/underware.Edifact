using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class RFR : Segment
    {
        public RFR() : base("RFR", "Reference") { }

        [ElementInfo(0, "REFERENCE", "M", "1", "", "")]
        public E506 E506 { get; set; }


    }
}