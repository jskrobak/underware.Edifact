using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01A.Composites;

namespace underware.Edifact.D01A.Segments
{
    public class DSG : Segment
    {
        public DSG() : base("DSG", "Dosage administration") { }

        [ElementInfo(0, "Dosage administration code qualifier", "M", "1", "an..3", "")]
        public string E6085 { get; set; }
        [ElementInfo(1, "DOSAGE DETAILS", "C", "1", "", "")]
        public C838 C838 { get; set; }


    }
}