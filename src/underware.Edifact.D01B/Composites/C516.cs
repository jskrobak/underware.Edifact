using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01B.Composites
{
    public class C516
    {
        [ElementInfo(0, "Monetary amount type code qualifier", "M", "", "an..3", "")]
        public string E5025 { get; set; }
        [ElementInfo(1, "Monetary amount", "C", "", "n..35", "")]
        public string E5004 { get; set; }
        [ElementInfo(2, "Currency identification code", "C", "", "an..3", "")]
        public string E6345 { get; set; }
        [ElementInfo(3, "Currency type code qualifier", "C", "", "an..3", "")]
        public string E6343 { get; set; }
        [ElementInfo(4, "Status description code", "C", "", "an..3", "")]
        public string E4405 { get; set; }

    }
}