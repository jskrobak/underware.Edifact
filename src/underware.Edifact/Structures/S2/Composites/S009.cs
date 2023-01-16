using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S2.Composites
{
    public class S009
    {
        [ElementInfo(0, "Message type", "M", "", "an..6", "")]
        public string E0065 { get; set; }

        [ElementInfo(1, "Message version number", "M", "", "an..3", "")]
        public string E0052 { get; set; }

        [ElementInfo(2, "Message release number", "M", "", "an..3", "")]
        public string E0054 { get; set; }

        [ElementInfo(3, "Controlling agency", "M", "", "an..2", "")]
        public string E0051 { get; set; }

        [ElementInfo(4, "Association assigned code", "C", "", "an..6", "")]
        public string E0057 { get; set; }
    }
}
