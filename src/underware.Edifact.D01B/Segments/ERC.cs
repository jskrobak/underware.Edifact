using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class ERC : Segment
    {
        public ERC() : base("ERC", "Application error information") { }

        [ElementInfo(0, "APPLICATION ERROR DETAIL", "M", "1", "", "")]
        public C901 C901 { get; set; }


    }
}