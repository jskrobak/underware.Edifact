using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01A.Composites
{
    public class E011
    {
        [ElementInfo(0, "Rate or tariff class description code", "M", "", "an..9", "")]
        public string E5243 { get; set; }
        [ElementInfo(1, "Processing indicator description code", "C", "", "an..3", "")]
        public string E7365 { get; set; }

    }
}