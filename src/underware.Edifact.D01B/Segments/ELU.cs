using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class ELU : Segment
    {
        public ELU() : base("ELU", "Data element usage details") { }

        [ElementInfo(0, "Data element tag identifier", "M", "1", "an..4", "")]
        public string E9162 { get; set; }
        [ElementInfo(1, "Requirement designator code", "C", "1", "an..3", "")]
        public string E7299 { get; set; }
        [ElementInfo(2, "Sequence position identifier", "C", "1", "an..10", "")]
        public string E1050 { get; set; }
        [ElementInfo(3, "Maintenance operation code", "C", "1", "an..3", "")]
        public string E4513 { get; set; }
        [ElementInfo(4, "Occurrences maximum number", "C", "1", "n..7", "")]
        public string E6176 { get; set; }
        [ElementInfo(5, "Code value source code", "C", "1", "an..3", "")]
        public string E9453 { get; set; }
        [ElementInfo(6, "Validation criteria code", "C", "1", "an..3", "")]
        public string E9285 { get; set; }
        [ElementInfo(7, "Data element usage type code", "C", "1", "an..3", "")]
        public string E9175 { get; set; }


    }
}