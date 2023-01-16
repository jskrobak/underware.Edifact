using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S4.Composites
{
    public class S004
    {
        [ElementInfo(0, "Date", "M", "", "n8", "")]
        public string E0017 { get; set; }
        [ElementInfo(1, "Time", "M", "", "n4", "")]
        public string E0019 { get; set; }

    }
}