using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class RFF : Segment
    {
        public RFF() : base("RFF", "Reference") { }

        [ElementInfo(0, "REFERENCE", "M", "1", "", "")]
        public C506 C506 { get; set; }


    }
}