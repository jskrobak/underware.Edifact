using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01B.Composites
{
    public class C822
    {
        [ElementInfo(0, "Damage area description code", "C", "", "an..4", "")]
        public string E7503 { get; set; }
        [ElementInfo(1, "Code list identification code", "C", "", "an..17", "")]
        public string E1131 { get; set; }
        [ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "")]
        public string E3055 { get; set; }
        [ElementInfo(3, "Damage area description", "C", "", "an..35", "")]
        public string E7502 { get; set; }

    }
}