using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S4.Composites
{
    public class S020
    {
        [ElementInfo(0, "Reference qualifier", "M", "", "an..3", "")]
        public string E0813 { get; set; }
        [ElementInfo(1, "Reference identification number", "M", "", "an..35", "")]
        public string E0802 { get; set; }

    }
}