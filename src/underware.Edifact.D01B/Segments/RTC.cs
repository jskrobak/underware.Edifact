using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class RTC : Segment
    {
        public RTC() : base("RTC", "Rate types") { }

        [ElementInfo(0, "Rate type identifier", "M", "99", "an..20", "")]
        public string E5263 { get; set; }


    }
}