using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D96A.Composites;
using underware.Edifact.Structures.Common.Segments.Interfaces;

namespace underware.Edifact.D96A.Segments
{
    public class RFF() : Segment("RFF", "Reference"), IRFF
    {
        [ElementInfo(0, "REFERENCE", "M", "1", "", "")]
        public C506 C506 { get; set; }

        public string Qualifier => C506.E1153;

        public string Value => C506.E1154;
    }
}