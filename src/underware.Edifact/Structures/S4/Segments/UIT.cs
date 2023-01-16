using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S4.Composites;

namespace underware.Edifact.Structures.S4.Segments
{
    public class UIT : Segment
    {
        public UIT() : base("UIT", "Interactive message trailer") { }
        public UIT(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Interactive message reference number", "C", "1", "an..35", "")]
        public string E0340 { get; set; }
        [ElementInfo(1, "Number of segments in a message", "C", "1", "n..10", "")]
        public string E0074 { get; set; }


    }
}