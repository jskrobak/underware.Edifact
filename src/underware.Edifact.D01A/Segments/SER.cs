using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01A.Composites;

namespace underware.Edifact.D01A.Segments
{
    public class SER : Segment
    {
        public SER() : base("SER", "Facility information") { }

        [ElementInfo(0, "FACILITIES", "C", "99", "", "")]
        public E965 E965 { get; set; }
        [ElementInfo(1, "Action request/notification description code", "C", "1", "an..3", "")]
        public string E1229 { get; set; }
        [ElementInfo(2, "Units quantity", "C", "1", "n..15", "")]
        public string E6350 { get; set; }
        [ElementInfo(3, "DATE AND TIME INFORMATION", "C", "99", "", "")]
        public E013 E013 { get; set; }
        [ElementInfo(4, "Days of week set identifier", "C", "1", "an..7", "")]
        public string E2160 { get; set; }


    }
}