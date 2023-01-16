using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00B.Composites;

namespace underware.Edifact.D00B.Segments
{
    public class CLA : Segment
    {
        public CLA() : base("CLA", "Clause identification") { }

        [ElementInfo(0, "Clause code qualifier", "M", "1", "an..3", "")]
        public string E4059 { get; set; }
        [ElementInfo(1, "CLAUSE NAME", "C", "1", "", "")]
        public C970 C970 { get; set; }


    }
}