using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01A.Composites;

namespace underware.Edifact.D01A.Segments
{
    public class CTA : Segment
    {
        public CTA() : base("CTA", "Contact information") { }

        [ElementInfo(0, "Contact function code", "C", "1", "an..3", "")]
        public string E3139 { get; set; }
        [ElementInfo(1, "DEPARTMENT OR EMPLOYEE DETAILS", "C", "1", "", "")]
        public C056 C056 { get; set; }


    }
}