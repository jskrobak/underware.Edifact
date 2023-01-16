using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01B.Composites
{
    public class E961
    {
        [ElementInfo(0, "Transport means description code", "C", "", "an..8", "")]
        public string E8179 { get; set; }
        [ElementInfo(1, "Journey stops quantity", "C", "", "n..3", "")]
        public string E8216 { get; set; }
        [ElementInfo(2, "Journey leg duration value", "C", "", "an..6", "")]
        public string E2162 { get; set; }
        [ElementInfo(3, "Percentage", "C", "", "n..10", "")]
        public string E5482 { get; set; }
        [ElementInfo(4, "Days of week set identifier", "C", "", "an..7", "")]
        public string E2160 { get; set; }
        [ElementInfo(5, "Date or time or period value", "C", "", "an..35", "")]
        public string E2380 { get; set; }
        [ElementInfo(6, "Transport means change indicator code", "C", "", "an1", "")]
        public string E8215 { get; set; }
        [ElementInfo(7, "Location name code", "C", "", "an..25", "")]
        public string E3225 { get; set; }
        [ElementInfo(8, "Location name code", "C", "", "an..25", "")]
        public string E3225_0 { get; set; }
        [ElementInfo(9, "Location name code", "C", "", "an..25", "")]
        public string E3225_1 { get; set; }

    }
}