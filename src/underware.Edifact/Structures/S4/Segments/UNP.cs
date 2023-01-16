using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S4.Composites;

namespace underware.Edifact.Structures.S4.Segments
{
    public class UNP : Segment
    {
        public UNP() : base("UNP", "Object trailer") { }
        public UNP(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Length of object in octets of bits", "M", "1", "n..18", "")]
        public string E0810 { get; set; }
        [ElementInfo(1, "Package reference number", "M", "1", "an..35", "")]
        public string E0800 { get; set; }


    }
}