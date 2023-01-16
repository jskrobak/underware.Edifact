using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01A.Composites
{
    public class E520
    {
        [ElementInfo(0, "Frequency value", "M", "", "n..9", "")]
        public string E6072 { get; set; }
        [ElementInfo(1, "Measurement unit code", "C", "", "an..3", "")]
        public string E6411 { get; set; }
        [ElementInfo(2, "Date or time or period value", "C", "", "an..35", "")]
        public string E2380 { get; set; }
        [ElementInfo(3, "Date or time or period format code", "C", "", "an..3", "")]
        public string E2379 { get; set; }

    }
}