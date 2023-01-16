using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.Common.Interfaces;
using underware.Edifact.Structures.S3.Composites;

namespace underware.Edifact.Structures.S3.Segments
{
    public class USR : Segment, IUSR
    {
        public USR() : base("USR", "Security result") { }
        public USR(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "VALIDATION RESULT", "M", "2", "", "")]
        public S508 S508 { get; set; }

        public string Signature => S508.E0563;
    }
}