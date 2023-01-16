using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00B.Composites;

namespace underware.Edifact.D00B.Segments
{
    public class ARD : Segment
    {
        public ARD() : base("ARD", "Monetary amount function") { }

        [ElementInfo(0, "MONETARY AMOUNT FUNCTION", "C", "1", "", "")]
        public C549 C549 { get; set; }
        [ElementInfo(1, "MONETARY AMOUNT FUNCTION DETAIL", "C", "8", "", "")]
        public C008 C008 { get; set; }


    }
}