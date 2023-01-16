using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S2.Composites
{
    public class S001
    {
        [ElementInfo(0, "Syntax identifier", "M", "", "a4", "")]
        public string E0001 { get; set; }
        [ElementInfo(1, "Syntax version number", "M", "", "n1", "")]
        public string E0002 { get; set; }

    }
}