using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S4.Composites;

namespace underware.Edifact.Structures.S4.Segments
{
    public class USE : Segment
    {
        public USE() : base("USE", "Security message relation") { }
        public USE(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Message relation, coded", "M", "1", "an..3", "")]
        public string E0565 { get; set; }


    }
}