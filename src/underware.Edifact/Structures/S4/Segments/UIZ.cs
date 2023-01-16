using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S4.Composites;

namespace underware.Edifact.Structures.S4.Segments
{
    public class UIZ : Segment
    {
        public UIZ() : base("UIZ", "Interactive interchange trailer") { }
        public UIZ(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "DIALOGUE REFERENCE", "C", "1", "", "")]
        public S302 S302 { get; set; }
        [ElementInfo(1, "Interchange control count", "C", "1", "n..6", "")]
        public string E0036 { get; set; }
        [ElementInfo(2, "Duplicate Indicator", "C", "1", "a1", "")]
        public string E0325 { get; set; }


    }
}