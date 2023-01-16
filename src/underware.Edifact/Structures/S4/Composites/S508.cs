using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S4.Composites
{
    public class S508
    {
        [ElementInfo(0, "Validation value, qualifier", "M", "", "an..3", "")]
        public string E0563 { get; set; }
        [ElementInfo(1, "Validation value", "C", "", "an..512", "")]
        public string E0560 { get; set; }

    }
}