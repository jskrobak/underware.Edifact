using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01B.Composites
{
    public class E009
    {
        [ElementInfo(0, "Date value", "M", "", "an..14", "")]
        public string E2000 { get; set; }
        [ElementInfo(1, "Requested information description", "C", "", "an..35", "")]
        public string E4510 { get; set; }

    }
}