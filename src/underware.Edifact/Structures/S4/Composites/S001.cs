using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S4.Composites
{
    public class S001
    {
        [ElementInfo(0, "Syntax identifier", "M", "", "a4", "")]
        public string E0001 { get; set; }
        [ElementInfo(1, "Syntax version number", "M", "", "an1", "")]
        public string E0002 { get; set; }
        [ElementInfo(2, "Service code list directory version number", "C", "", "an..6", "")]
        public string E0080 { get; set; }
        [ElementInfo(3, "Character encoding, coded", "C", "", "an..3", "")]
        public string E0133 { get; set; }

    }
}