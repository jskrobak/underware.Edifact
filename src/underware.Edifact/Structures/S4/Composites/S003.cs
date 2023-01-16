using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S4.Composites
{
    public class S003
    {
        [ElementInfo(0, "Interchange recipient identification", "M", "", "an..35", "")]
        public string E0010 { get; set; }
        [ElementInfo(1, "Identification code qualifier", "C", "", "an..4", "")]
        public string E0007 { get; set; }
        [ElementInfo(2, "Interchange recipient internal identification", "C", "", "an..35", "")]
        public string E0014 { get; set; }
        [ElementInfo(3, "Interchange recipient internal sub-identification", "C", "", "an..35", "")]
        public string E0046 { get; set; }

    }
}