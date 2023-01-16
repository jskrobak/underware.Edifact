using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class GRU : Segment
    {
        public GRU() : base("GRU", "Segment group usage details") { }

        [ElementInfo(0, "Group identifier", "M", "1", "an..4", "")]
        public string E9164 { get; set; }
        [ElementInfo(1, "Requirement designator code", "C", "1", "an..3", "")]
        public string E7299 { get; set; }
        [ElementInfo(2, "Occurrences maximum number", "C", "1", "n..7", "")]
        public string E6176 { get; set; }
        [ElementInfo(3, "Maintenance operation code", "C", "1", "an..3", "")]
        public string E4513 { get; set; }
        [ElementInfo(4, "Sequence position identifier", "C", "1", "an..10", "")]
        public string E1050 { get; set; }


    }
}