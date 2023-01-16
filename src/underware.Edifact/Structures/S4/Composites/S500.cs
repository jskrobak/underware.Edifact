using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S4.Composites
{
    public class S500
    {
        [ElementInfo(0, "Security party qualifier", "M", "", "an..3", "")]
        public string E0577 { get; set; }
        [ElementInfo(1, "Key name", "C", "", "an..35", "")]
        public string E0538 { get; set; }
        [ElementInfo(2, "Security party identification", "C", "", "an..512", "")]
        public string E0511 { get; set; }
        [ElementInfo(3, "Security party code list qualifier", "C", "", "an..3", "")]
        public string E0513 { get; set; }
        [ElementInfo(4, "Security party code list responsible agency, coded", "C", "", "an..3", "")]
        public string E0515 { get; set; }
        [ElementInfo(5, "Security party name", "C", "", "an..35", "")]
        public string E0586 { get; set; }
        [ElementInfo(6, "Security party name", "C", "", "an..35", "")]
        public string E0586_1 { get; set; }
        [ElementInfo(7, "Security party name", "C", "", "an..35", "")]
        public string E0586_2 { get; set; }

    }
}