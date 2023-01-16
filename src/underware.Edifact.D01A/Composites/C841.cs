using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01A.Composites
{
    public class C841
    {
        [ElementInfo(0, "Discharge type description code", "C", "", "an..3", "")]
        public string E9447 { get; set; }
        [ElementInfo(1, "Code list identification code", "C", "", "an..17", "")]
        public string E1131 { get; set; }
        [ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "")]
        public string E3055 { get; set; }
        [ElementInfo(3, "Discharge type description", "C", "", "an..35", "")]
        public string E9446 { get; set; }

    }
}