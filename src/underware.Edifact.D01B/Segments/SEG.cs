using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class SEG : Segment
    {
        public SEG() : base("SEG", "Segment identification") { }

        [ElementInfo(0, "Segment tag identifier", "M", "1", "an..3", "")]
        public string E9166 { get; set; }
        [ElementInfo(1, "Designated class code", "C", "1", "an..3", "")]
        public string E1507 { get; set; }
        [ElementInfo(2, "Maintenance operation code", "C", "1", "an..3", "")]
        public string E4513 { get; set; }


    }
}