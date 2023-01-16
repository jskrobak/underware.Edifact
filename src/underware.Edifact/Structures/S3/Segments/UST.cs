using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S3.Composites;

namespace underware.Edifact.Structures.S3.Segments
{
    public class UST : Segment
    {
        public UST() : base("UST", "Security trailer") { }
        public UST(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Security reference number", "M", "1", "an..14", "")]
        public string E0534 { get; set; }
        [ElementInfo(1, "Number of security segments", "M", "1", "n..10", "")]
        public string E0588 { get; set; }


    }
}