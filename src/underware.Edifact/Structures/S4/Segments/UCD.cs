using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S4.Composites;

namespace underware.Edifact.Structures.S4.Segments
{
    public class UCD : Segment
    {
        public UCD() : base("UCD", "Data element error indication") { }
        public UCD(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Syntax error, coded", "M", "1", "an..3", "")]
        public string E0085 { get; set; }
        [ElementInfo(1, "DATA ELEMENT IDENTIFICATION", "M", "1", "", "")]
        public S011 S011 { get; set; }


    }
}