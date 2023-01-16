using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00B.Composites
{
    public class C030
    {
        [ElementInfo(0, "Event type description code", "C", "", "an..3", "")]
        public string E9171 { get; set; }
        [ElementInfo(1, "Code list identification code", "C", "", "an..17", "")]
        public string E1131 { get; set; }
        [ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "")]
        public string E3055 { get; set; }
        [ElementInfo(3, "Event type description", "C", "", "an..70", "")]
        public string E9170 { get; set; }

    }
}