using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04A.Composites;

namespace underware.Edifact.D04A.Segments
{
    public class RFF() : Segment("RFF", "Reference")
    {
        [ElementInfo(0, "REFERENCE", "M", "1", "", "")]
        public C506 C506 { get; set; }

        public string Qualifier => C506.E1153;

        public string Value => C506.E1154;
    }
}