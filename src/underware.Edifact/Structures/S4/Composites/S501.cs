using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S4.Composites
{
    public class S501
    {
        [ElementInfo(0, "Date and time qualifier", "M", "", "an..3", "")]
        public string E0517 { get; set; }
        [ElementInfo(1, "Event date", "C", "", "n..8", "")]
        public string E0338 { get; set; }
        [ElementInfo(2, "Event time", "C", "", "an..15", "")]
        public string E0314 { get; set; }
        [ElementInfo(3, "Report language, coded", "C", "", "an..3", "")]
        public string E0335 { get; set; }

    }
}