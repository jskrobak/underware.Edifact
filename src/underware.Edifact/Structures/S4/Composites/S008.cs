using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S4.Composites
{
    public class S008
    {
        [ElementInfo(0, "Message version number", "M", "", "an..3", "")]
        public string E0052 { get; set; }
        [ElementInfo(1, "Message release number", "M", "", "an..3", "")]
        public string E0054 { get; set; }
        [ElementInfo(2, "Association assigned code", "C", "", "an..6", "")]
        public string E0057 { get; set; }

    }
}