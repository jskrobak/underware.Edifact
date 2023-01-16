using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S4.Composites
{
    public class S303
    {
        [ElementInfo(0, "Transaction control reference", "M", "", "an..35", "")]
        public string E0306 { get; set; }
        [ElementInfo(1, "Initiator reference identification", "C", "", "an..35", "")]
        public string E0303 { get; set; }
        [ElementInfo(2, "Controlling agency, coded", "C", "", "an..3", "")]
        public string E0051 { get; set; }

    }
}