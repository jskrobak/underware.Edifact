using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S3.Composites;

namespace underware.Edifact.Structures.S3.Segments
{
    public class USY : Segment
    {
        public USY() : base("USY", "Security on references") { }
        public USY(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Security reference number", "M", "1", "an..14", "")]
        public string E0534 { get; set; }
        [ElementInfo(1, "VALIDATION RESULT", "C", "2", "", "")]
        public S508 S508 { get; set; }
        [ElementInfo(2, "Security error, coded", "C", "1", "an..3", "")]
        public string E0571 { get; set; }


    }
}