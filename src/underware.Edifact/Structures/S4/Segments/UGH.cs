using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S4.Composites;

namespace underware.Edifact.Structures.S4.Segments
{
    public class UGH : Segment
    {
        public UGH() : base("UGH", "Anti-collision segment group header") { }
        public UGH(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Anti-collision segment group identification", "M", "1", "an..4", "")]
        public string E0087 { get; set; }


    }
}