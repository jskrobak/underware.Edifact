using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01A.Composites
{
    public class C504
    {
        [ElementInfo(0, "Currency usage code qualifier", "M", "", "an..3", "")]
        public string E6347 { get; set; }
        [ElementInfo(1, "Currency identification code", "C", "", "an..3", "")]
        public string E6345 { get; set; }
        [ElementInfo(2, "Currency type code qualifier", "C", "", "an..3", "")]
        public string E6343 { get; set; }
        [ElementInfo(3, "Currency rate value", "C", "", "n..4", "")]
        public string E6348 { get; set; }

    }
}