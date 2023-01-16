using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S4.Composites
{
    public class S007
    {
        [ElementInfo(0, "Application recipient identification", "M", "", "an..35", "")]
        public string E0044 { get; set; }
        [ElementInfo(1, "Identification code qualifier", "C", "", "an..4", "")]
        public string E0007 { get; set; }

    }
}