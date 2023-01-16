using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S4.Composites
{
    public class S010
    {
        [ElementInfo(0, "Sequence of transfers", "M", "", "n..2", "")]
        public string E0070 { get; set; }
        [ElementInfo(1, "First and last transfer", "C", "", "a1", "")]
        public string E0073 { get; set; }

    }
}