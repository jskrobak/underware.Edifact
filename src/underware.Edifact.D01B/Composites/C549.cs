using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01B.Composites
{
    public class C549
    {
        [ElementInfo(0, "Monetary amount function description code", "C", "", "an..3", "")]
        public string E5007 { get; set; }
        [ElementInfo(1, "Code list identification code", "C", "", "an..17", "")]
        public string E1131 { get; set; }
        [ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "")]
        public string E3055 { get; set; }
        [ElementInfo(3, "Monetary amount function description", "C", "", "an..70", "")]
        public string E5006 { get; set; }

    }
}