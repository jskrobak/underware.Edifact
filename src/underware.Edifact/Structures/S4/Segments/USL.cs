using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S4.Composites;

namespace underware.Edifact.Structures.S4.Segments
{
    public class USL : Segment
    {
        public USL() : base("USL", "Security list status") { }
        public USL(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Security status, coded", "M", "1", "an..3", "")]
        public string E0567 { get; set; }
        [ElementInfo(1, "LIST PARAMETER", "C", "9", "", "")]
        public S504 S504 { get; set; }


    }
}