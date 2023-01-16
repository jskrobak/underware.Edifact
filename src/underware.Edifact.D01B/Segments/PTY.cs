using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class PTY : Segment
    {
        public PTY() : base("PTY", "Priority") { }

        [ElementInfo(0, "Priority type code qualifier", "M", "1", "an..3", "")]
        public string E4035 { get; set; }
        [ElementInfo(1, "PRIORITY DETAILS", "C", "1", "", "")]
        public C585 C585 { get; set; }


    }
}