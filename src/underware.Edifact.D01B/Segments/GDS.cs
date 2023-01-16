using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class GDS : Segment
    {
        public GDS() : base("GDS", "Nature of cargo") { }

        [ElementInfo(0, "NATURE OF CARGO", "C", "1", "", "")]
        public C703 C703 { get; set; }


    }
}