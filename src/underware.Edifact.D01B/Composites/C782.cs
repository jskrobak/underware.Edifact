using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01B.Composites
{
    public class C782
    {
        [ElementInfo(0, "Data set identifier", "M", "", "an..35", "")]
        public string E1520 { get; set; }
        [ElementInfo(1, "Object identification code qualifier", "C", "", "an..3", "")]
        public string E7405 { get; set; }

    }
}