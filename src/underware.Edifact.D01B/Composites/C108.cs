using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01B.Composites
{
    public class C108
    {
        [ElementInfo(0, "Free text value", "M", "", "an..512", "")]
        public string E4440 { get; set; }
        [ElementInfo(1, "Free text value", "C", "", "an..512", "")]
        public string E4440_0 { get; set; }
        [ElementInfo(2, "Free text value", "C", "", "an..512", "")]
        public string E4440_1 { get; set; }
        [ElementInfo(3, "Free text value", "C", "", "an..512", "")]
        public string E4440_2 { get; set; }
        [ElementInfo(4, "Free text value", "C", "", "an..512", "")]
        public string E4440_3 { get; set; }

    }
}