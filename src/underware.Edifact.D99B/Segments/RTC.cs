using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D99B.Composites;

namespace underware.Edifact.D99B.Segments
{
    public class RTC : Segment
    {
        public RTC() : base("RTC", "Rate types"){}

				[ElementInfo(0, "Rate type identification", "M", "99", "an..20", "" )]
public string E5263 { get; set; }

		
    }
}