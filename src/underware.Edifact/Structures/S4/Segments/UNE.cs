using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S4.Composites;

namespace underware.Edifact.Structures.S4.Segments
{
    public class UNE : Segment
    {
        public UNE() : base("UNE", "Group trailer") { }
        public UNE(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Group control count", "M", "1", "n..6", "")]
        public string E0060 { get; set; }
        [ElementInfo(1, "Group reference number", "M", "1", "an..14", "")]
        public string E0048 { get; set; }


    }
}