using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class ARR : Segment
    {
        public ARR() : base("ARR", "Array information") { }

        [ElementInfo(0, "POSITION IDENTIFICATION", "C", "1", "", "")]
        public C778 C778 { get; set; }
        [ElementInfo(1, "ARRAY CELL DETAILS", "C", "9999", "", "")]
        public C770 C770 { get; set; }


    }
}