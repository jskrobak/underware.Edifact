using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01B.Composites
{
    public class C593
    {
        [ElementInfo(0, "Account identifier", "M", "", "an..35", "")]
        public string E1147 { get; set; }
        [ElementInfo(1, "Code list identification code", "C", "", "an..17", "")]
        public string E1131 { get; set; }
        [ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "")]
        public string E3055 { get; set; }
        [ElementInfo(3, "Account abbreviated name", "C", "", "an..17", "")]
        public string E1148 { get; set; }
        [ElementInfo(4, "Account name", "C", "", "an..35", "")]
        public string E1146 { get; set; }
        [ElementInfo(5, "Account name", "C", "", "an..35", "")]
        public string E1146_0 { get; set; }
        [ElementInfo(6, "Currency identification code", "C", "", "an..3", "")]
        public string E6345 { get; set; }

    }
}