using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01A.Composites
{
    public class E972
    {
        [ElementInfo(0, "Business function code", "C", "", "an..3", "")]
        public string E4025 { get; set; }
        [ElementInfo(1, "Message function code", "C", "", "an..3", "")]
        public string E1225 { get; set; }
        [ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "")]
        public string E3055 { get; set; }
        [ElementInfo(3, "Message function code", "C", "", "an..3", "")]
        public string E1225_0 { get; set; }
        [ElementInfo(4, "Message function code", "C", "", "an..3", "")]
        public string E1225_1 { get; set; }
        [ElementInfo(5, "Message function code", "C", "", "an..3", "")]
        public string E1225_2 { get; set; }
        [ElementInfo(6, "Message function code", "C", "", "an..3", "")]
        public string E1225_3 { get; set; }
        [ElementInfo(7, "Message function code", "C", "", "an..3", "")]
        public string E1225_4 { get; set; }
        [ElementInfo(8, "Message function code", "C", "", "an..3", "")]
        public string E1225_5 { get; set; }
        [ElementInfo(9, "Message function code", "C", "", "an..3", "")]
        public string E1225_6 { get; set; }
        [ElementInfo(10, "Message function code", "C", "", "an..3", "")]
        public string E1225_7 { get; set; }
        [ElementInfo(11, "Message function code", "C", "", "an..3", "")]
        public string E1225_8 { get; set; }

    }
}