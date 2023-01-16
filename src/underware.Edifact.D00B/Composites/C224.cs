using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00B.Composites
{
    public class C224
    {
        [ElementInfo(0, "Equipment size and type description code", "C", "", "an..10", "")]
        public string E8155 { get; set; }
        [ElementInfo(1, "Code list identification code", "C", "", "an..17", "")]
        public string E1131 { get; set; }
        [ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "")]
        public string E3055 { get; set; }
        [ElementInfo(3, "Equipment size and type description", "C", "", "an..35", "")]
        public string E8154 { get; set; }

    }
}