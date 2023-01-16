using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S4.Composites
{
    public class S305
    {
        [ElementInfo(0, "Dialogue identification", "M", "", "an..14", "")]
        public string E0311 { get; set; }
        [ElementInfo(1, "Dialogue version number", "C", "", "an..3", "")]
        public string E0342 { get; set; }
        [ElementInfo(2, "Dialogue release number", "C", "", "an..3", "")]
        public string E0344 { get; set; }
        [ElementInfo(3, "Controlling agency, coded", "C", "", "an..3", "")]
        public string E0051 { get; set; }

    }
}