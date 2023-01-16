using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S4.Composites
{
    public class S017
    {
        [ElementInfo(0, "Message implementation guideline identification", "M", "", "an..14", "")]
        public string E0121 { get; set; }
        [ElementInfo(1, "Message implementation guideline version number", "C", "", "an..3", "")]
        public string E0122 { get; set; }
        [ElementInfo(2, "Message implementation guideline release number", "C", "", "an..3", "")]
        public string E0124 { get; set; }
        [ElementInfo(3, "Controlling agency, coded", "C", "", "an..3", "")]
        public string E0051 { get; set; }

    }
}