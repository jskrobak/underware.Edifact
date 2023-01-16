using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S4.Composites
{
    public class S300
    {
        [ElementInfo(0, "Event date", "C", "", "n..8", "")]
        public string E0338 { get; set; }
        [ElementInfo(1, "Event time", "C", "", "an..15", "")]
        public string E0314 { get; set; }
        [ElementInfo(2, "Time offset", "C", "", "n4", "")]
        public string E0336 { get; set; }

    }
}