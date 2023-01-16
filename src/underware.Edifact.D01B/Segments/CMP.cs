using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class CMP : Segment
    {
        public CMP() : base("CMP", "Composite data element identification") { }

        [ElementInfo(0, "Composite data element tag identifier", "M", "1", "an..4", "")]
        public string E9146 { get; set; }
        [ElementInfo(1, "Designated class code", "C", "1", "an..3", "")]
        public string E1507 { get; set; }
        [ElementInfo(2, "Maintenance operation code", "C", "1", "an..3", "")]
        public string E4513 { get; set; }


    }
}