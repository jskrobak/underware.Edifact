using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class QVR : Segment
    {
        public QVR() : base("QVR", "Quantity variances") { }

        [ElementInfo(0, "QUANTITY DIFFERENCE INFORMATION", "C", "1", "", "")]
        public C279 C279 { get; set; }
        [ElementInfo(1, "Discrepancy nature identification code", "C", "1", "an..3", "")]
        public string E4221 { get; set; }
        [ElementInfo(2, "REASON FOR CHANGE", "C", "1", "", "")]
        public C960 C960 { get; set; }


    }
}