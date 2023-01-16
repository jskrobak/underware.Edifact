using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00B.Composites;

namespace underware.Edifact.D00B.Segments
{
    public class SEQ : Segment
    {
        public SEQ() : base("SEQ", "Sequence details") { }

        [ElementInfo(0, "Action request/notification description code", "C", "1", "an..3", "")]
        public string E1229 { get; set; }
        [ElementInfo(1, "SEQUENCE INFORMATION", "C", "1", "", "")]
        public C286 C286 { get; set; }


    }
}