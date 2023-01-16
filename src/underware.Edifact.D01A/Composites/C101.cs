using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01A.Composites
{
    public class C101
    {
        [ElementInfo(0, "Religion name code", "C", "", "an..3", "")]
        public string E3483 { get; set; }
        [ElementInfo(1, "Code list identification code", "C", "", "an..17", "")]
        public string E1131 { get; set; }
        [ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "")]
        public string E3055 { get; set; }
        [ElementInfo(3, "Religion name", "C", "", "an..35", "")]
        public string E3482 { get; set; }

    }
}