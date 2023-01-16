using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01C.Composites;

namespace underware.Edifact.D01C.Segments
{
    public class RTC : Segment
    {
        public RTC() : base("RTC", "Rate types"){}

				[ElementInfo(0, "Rate type identifier", "M", "99", "an..20", "" )]
public string E5263 { get; set; }

		
    }
}