using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00B.Composites;

namespace underware.Edifact.D00B.Segments
{
    public class DMS : Segment
    {
        public DMS() : base("DMS", "Document/message summary") { }

        [ElementInfo(0, "DOCUMENT/MESSAGE IDENTIFICATION", "C", "1", "", "")]
        public C106 C106 { get; set; }
        [ElementInfo(1, "DOCUMENT/MESSAGE NAME", "C", "1", "", "")]
        public C002 C002 { get; set; }
        [ElementInfo(2, "Item total quantity", "C", "1", "n..15", "")]
        public string E7240 { get; set; }


    }
}