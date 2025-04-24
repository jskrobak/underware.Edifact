using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class CNT : Segment
    {
        public CNT() : base("CNT", "Control total") { }

        public string Qualifier => C270.E6069;
        
        [ElementInfo(0, "CONTROL", "M", "1", "", "")]
        public C270 C270 { get; set; }


    }
}