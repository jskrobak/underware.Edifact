using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01A.Composites
{
    public class C286
    {
        [ElementInfo(0, "Sequence position identifier", "M", "", "an..10", "")]
        public string E1050 { get; set; }
        [ElementInfo(1, "Sequence identifier source code", "C", "", "an..3", "")]
        public string E1159 { get; set; }
        [ElementInfo(2, "Code list identification code", "C", "", "an..17", "")]
        public string E1131 { get; set; }
        [ElementInfo(3, "Code list responsible agency code", "C", "", "an..3", "")]
        public string E3055 { get; set; }

    }
}