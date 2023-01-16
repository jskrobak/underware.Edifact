using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01B.Composites
{
    public class E980
    {
        [ElementInfo(0, "Special requirement type code", "M", "", "an..4", "")]
        public string E4187 { get; set; }
        [ElementInfo(1, "Status description code", "C", "", "an..3", "")]
        public string E4405 { get; set; }
        [ElementInfo(2, "Quantity", "C", "", "an..35", "")]
        public string E6060 { get; set; }
        [ElementInfo(3, "Party name", "C", "", "an..35", "")]
        public string E3036 { get; set; }
        [ElementInfo(4, "Processing indicator description code", "C", "", "an..3", "")]
        public string E7365 { get; set; }
        [ElementInfo(5, "Location name code", "C", "", "an..25", "")]
        public string E3225 { get; set; }
        [ElementInfo(6, "Location name code", "C", "", "an..25", "")]
        public string E3225_0 { get; set; }
        [ElementInfo(7, "Characteristic description code", "C", "", "an..17", "")]
        public string E7037 { get; set; }

    }
}