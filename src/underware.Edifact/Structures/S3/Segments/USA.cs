using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.Common.Interfaces;
using underware.Edifact.Structures.S3.Composites;

namespace underware.Edifact.Structures.S3.Segments
{
    public class USA : Segment, IUSA
    {
        public USA() : base("USA", "Security algorithm") { }
        public USA(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "SECURITY ALGORITHM", "M", "1", "", "")]
        public S502 S502 { get; set; }
        [ElementInfo(1, "ALGORITHM PARAMETER", "C", "9", "", "")]
        public S503 S503 { get; set; }

        public int HashAlgorithm => int.Parse(S502.E0527);
    }
}