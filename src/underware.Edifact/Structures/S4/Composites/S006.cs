using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S4.Composites
{
    public class S006
    {
        [ElementInfo(0, "Application sender identification", "M", "", "an..35", "")]
        public string E0040 { get; set; }
        [ElementInfo(1, "Identification code qualifier", "C", "", "an..4", "")]
        public string E0007 { get; set; }

    }
}