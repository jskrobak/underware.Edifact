using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02A.Composites;

namespace underware.Edifact.D02A.Segments
{
    public class RTE : Segment
    {
        public RTE() : base("RTE", "Rate details"){}

				[ElementInfo(0, "RATE DETAILS", "M", "1", "", "" )]
public C128 C128 { get; set; }
		[ElementInfo(1, "Status description code", "C", "1", "an..3", "" )]
public string E4405 { get; set; }

		
    }
}