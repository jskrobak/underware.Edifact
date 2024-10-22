using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S3.Composites;

namespace underware.Edifact.Structures.S2.Segments
{
    public class UNS : Segment
    {
        public UNS() : base("UNS", "Section control") { }

        public UNS(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Section identification", "M", "1", "a1", "")]
        public string E0081 { get; set; }


    }
}