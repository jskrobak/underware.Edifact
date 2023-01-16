using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01A.Composites
{
    public class C506
    {
        [ElementInfo(0, "Reference code qualifier", "M", "", "an..3", "")]
        public string E1153 { get; set; }
        [ElementInfo(1, "Reference identifier", "C", "", "an..70", "")]
        public string E1154 { get; set; }
        [ElementInfo(2, "Document line identifier", "C", "", "an..6", "")]
        public string E1156 { get; set; }
        [ElementInfo(3, "Reference version identifier", "C", "", "an..35", "")]
        public string E4000 { get; set; }
        [ElementInfo(4, "Revision identifier", "C", "", "an..6", "")]
        public string E1060 { get; set; }

    }
}