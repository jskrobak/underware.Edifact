using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01A.Composites
{
    public class C049
    {
        [ElementInfo(0, "Remuneration type name code", "C", "", "an..3", "")]
        public string E5315 { get; set; }
        [ElementInfo(1, "Code list identification code", "C", "", "an..17", "")]
        public string E1131 { get; set; }
        [ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "")]
        public string E3055 { get; set; }
        [ElementInfo(3, "Remuneration type name", "C", "", "an..35", "")]
        public string E5314 { get; set; }
        [ElementInfo(4, "Remuneration type name", "C", "", "an..35", "")]
        public string E5314_0 { get; set; }

    }
}