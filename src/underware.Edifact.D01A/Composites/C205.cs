using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01A.Composites
{
    public class C205
    {
        [ElementInfo(0, "Hazard identification code", "M", "", "an..7", "")]
        public string E8351 { get; set; }
        [ElementInfo(1, "Additional hazard classification identifier", "C", "", "an..7", "")]
        public string E8078 { get; set; }
        [ElementInfo(2, "Hazard code version identifier", "C", "", "an..10", "")]
        public string E8092 { get; set; }

    }
}