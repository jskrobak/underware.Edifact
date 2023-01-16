using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01B.Composites
{
    public class E014
    {
        [ElementInfo(0, "Reference identifier", "C", "", "an..70", "")]
        public string E1154 { get; set; }
        [ElementInfo(1, "Reference code qualifier", "C", "", "an..3", "")]
        public string E1153 { get; set; }

    }
}