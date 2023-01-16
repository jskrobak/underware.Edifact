using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S4.Composites
{
    public class S018
    {
        [ElementInfo(0, "Scenario identification", "M", "", "an..14", "")]
        public string E0127 { get; set; }
        [ElementInfo(1, "Scenario version number", "C", "", "an..3", "")]
        public string E0128 { get; set; }
        [ElementInfo(2, "Scenario release number", "C", "", "an..3", "")]
        public string E0130 { get; set; }
        [ElementInfo(3, "Controlling agency, coded", "C", "", "an..3", "")]
        public string E0051 { get; set; }

    }
}