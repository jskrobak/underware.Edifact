using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00B.Composites;

namespace underware.Edifact.D00B.Segments
{
    public class GOR : Segment
    {
        public GOR() : base("GOR", "Governmental requirements") { }

        [ElementInfo(0, "Transport movement code", "C", "1", "an..3", "")]
        public string E8323 { get; set; }
        [ElementInfo(1, "GOVERNMENT ACTION", "C", "1", "", "")]
        public C232 C232 { get; set; }
        [ElementInfo(2, "GOVERNMENT ACTION", "C", "1", "", "")]
        public C232 C232_0 { get; set; }
        [ElementInfo(3, "GOVERNMENT ACTION", "C", "1", "", "")]
        public C232 C232_1 { get; set; }
        [ElementInfo(4, "GOVERNMENT ACTION", "C", "1", "", "")]
        public C232 C232_2 { get; set; }


    }
}