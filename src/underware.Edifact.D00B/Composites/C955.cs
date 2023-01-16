using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00B.Composites
{
    public class C955
    {
        [ElementInfo(0, "Attribute type description code", "C", "", "an..17", "")]
        public string E9021 { get; set; }
        [ElementInfo(1, "Code list identification code", "C", "", "an..17", "")]
        public string E1131 { get; set; }
        [ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "")]
        public string E3055 { get; set; }
        [ElementInfo(3, "Attribute type description", "C", "", "an..70", "")]
        public string E9020 { get; set; }

    }
}