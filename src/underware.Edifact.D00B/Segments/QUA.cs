using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00B.Composites;

namespace underware.Edifact.D00B.Segments
{
    public class QUA : Segment
    {
        public QUA() : base("QUA", "Qualification") { }

        [ElementInfo(0, "Qualification type code qualifier", "M", "1", "an..3", "")]
        public string E9037 { get; set; }
        [ElementInfo(1, "QUALIFICATION CLASSIFICATION", "C", "1", "", "")]
        public C950 C950 { get; set; }


    }
}