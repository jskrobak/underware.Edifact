using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01A.Composites
{
    public class E964
    {
        [ElementInfo(0, "Time value", "C", "", "n4", "")]
        public string E2002 { get; set; }
        [ElementInfo(1, "Time value", "C", "", "n4", "")]
        public string E2002_0 { get; set; }
        [ElementInfo(2, "Check-in date or time value", "C", "", "an..10", "")]
        public string E2156 { get; set; }

    }
}