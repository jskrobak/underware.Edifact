using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01A.Composites
{
    public class C212
    {
        [ElementInfo(0, "Item identifier", "C", "", "an..35", "")]
        public string E7140 { get; set; }
        [ElementInfo(1, "Item type identification code", "C", "", "an..3", "")]
        public string E7143 { get; set; }
        [ElementInfo(2, "Code list identification code", "C", "", "an..17", "")]
        public string E1131 { get; set; }
        [ElementInfo(3, "Code list responsible agency code", "C", "", "an..3", "")]
        public string E3055 { get; set; }

    }
}