using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01A.Composites
{
    public class E990
    {
        [ElementInfo(0, "Sequence position identifier", "M", "", "an..10", "")]
        public string E1050 { get; set; }
        [ElementInfo(1, "Sequence position identifier", "C", "", "an..10", "")]
        public string E1050_0 { get; set; }
        [ElementInfo(2, "Sequence position identifier", "C", "", "an..10", "")]
        public string E1050_1 { get; set; }
        [ElementInfo(3, "Sequence position identifier", "C", "", "an..10", "")]
        public string E1050_2 { get; set; }
        [ElementInfo(4, "Sequence position identifier", "C", "", "an..10", "")]
        public string E1050_3 { get; set; }
        [ElementInfo(5, "Sequence position identifier", "C", "", "an..10", "")]
        public string E1050_4 { get; set; }
        [ElementInfo(6, "Sequence position identifier", "C", "", "an..10", "")]
        public string E1050_5 { get; set; }
        [ElementInfo(7, "Sequence position identifier", "C", "", "an..10", "")]
        public string E1050_6 { get; set; }
        [ElementInfo(8, "Sequence position identifier", "C", "", "an..10", "")]
        public string E1050_7 { get; set; }

    }
}