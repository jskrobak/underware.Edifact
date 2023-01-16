using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01B.Composites
{
    public class E966
    {
        [ElementInfo(0, "Party function code qualifier", "M", "", "an..3", "")]
        public string E3035 { get; set; }
        [ElementInfo(1, "Communication address identifier", "M", "", "an..512", "")]
        public string E3148 { get; set; }
        [ElementInfo(2, "Communication medium type code", "C", "", "an..3", "")]
        public string E3153 { get; set; }
        [ElementInfo(3, "Party name", "C", "", "an..35", "")]
        public string E3036 { get; set; }
        [ElementInfo(4, "Reference identifier", "C", "", "an..70", "")]
        public string E1154 { get; set; }

    }
}