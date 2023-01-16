using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S4.Composites
{
    public class S504
    {
        [ElementInfo(0, "List parameter qualifier", "M", "", "an..3", "")]
        public string E0575 { get; set; }
        [ElementInfo(1, "List parameter", "M", "", "an..70", "")]
        public string E0558 { get; set; }

    }
}