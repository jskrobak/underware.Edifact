using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01A.Composites
{
    public class C239
    {
        [ElementInfo(0, "Temperature value", "C", "", "n..15", "")]
        public string E6246 { get; set; }
        [ElementInfo(1, "Measurement unit code", "C", "", "an..3", "")]
        public string E6411 { get; set; }

    }
}