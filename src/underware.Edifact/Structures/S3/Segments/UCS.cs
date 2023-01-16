using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S3.Composites;

namespace underware.Edifact.Structures.S3.Segments
{
    public class UCS : Segment
    {
        public UCS() : base("UCS", "Segment error indication") { }
        public UCS(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Segment position in message", "M", "1", "n..6", "")]
        public string E0096 { get; set; }
        [ElementInfo(1, "Syntax error, coded", "C", "1", "an..3", "")]
        public string E0085 { get; set; }


    }
}