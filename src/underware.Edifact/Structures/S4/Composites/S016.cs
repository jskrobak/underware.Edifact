using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S4.Composites
{
    public class S016
    {
        [ElementInfo(0, "Message subset identification", "M", "", "an..14", "")]
        public string E0115 { get; set; }
        [ElementInfo(1, "Message subset version number", "C", "", "an..3", "")]
        public string E0116 { get; set; }
        [ElementInfo(2, "Message subset release number", "C", "", "an..3", "")]
        public string E0118 { get; set; }
        [ElementInfo(3, "Controlling agency, coded", "C", "", "an..3", "")]
        public string E0051 { get; set; }

    }
}