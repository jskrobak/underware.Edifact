using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00B.Composites
{
    public class E506
    {
        [ElementInfo(0, "Reference code qualifier", "M", "", "an..3", "")]
        public string E1153 { get; set; }
        [ElementInfo(1, "Reference identifier", "C", "", "an..70", "")]
        public string E1154 { get; set; }
        [ElementInfo(2, "Document line identifier", "C", "", "an..6", "")]
        public string E1156 { get; set; }
        [ElementInfo(3, "Reference version identifier", "C", "", "an..35", "")]
        public string E4000 { get; set; }
        [ElementInfo(4, "Party name", "C", "", "an..35", "")]
        public string E3036 { get; set; }

    }
}