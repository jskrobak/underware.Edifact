using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S4.Composites
{
    public class S307
    {
        [ElementInfo(0, "Report reason, coded", "C", "", "an..3", "")]
        public string E0333 { get; set; }
        [ElementInfo(1, "Report reason text", "C", "", "an..70", "")]
        public string E0332 { get; set; }
        [ElementInfo(2, "Report language, coded", "C", "", "an..3", "")]
        public string E0335 { get; set; }

    }
}