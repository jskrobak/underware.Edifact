using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01A.Composites
{
    public class C220
    {
        [ElementInfo(0, "Transport mode name code", "C", "", "an..3", "")]
        public string E8067 { get; set; }
        [ElementInfo(1, "Transport mode name", "C", "", "an..17", "")]
        public string E8066 { get; set; }

    }
}