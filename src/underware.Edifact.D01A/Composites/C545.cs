using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01A.Composites
{
    public class C545
    {
        [ElementInfo(0, "Index code qualifier", "M", "", "an..3", "")]
        public string E5013 { get; set; }
        [ElementInfo(1, "Index type identifier", "C", "", "an..17", "")]
        public string E5027 { get; set; }
        [ElementInfo(2, "Code list identification code", "C", "", "an..17", "")]
        public string E1131 { get; set; }
        [ElementInfo(3, "Code list responsible agency code", "C", "", "an..3", "")]
        public string E3055 { get; set; }

    }
}