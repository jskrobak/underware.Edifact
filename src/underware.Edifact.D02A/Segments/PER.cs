using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02A.Composites;

namespace underware.Edifact.D02A.Segments
{
    public class PER : Segment
    {
        public PER() : base("PER", "Period related details"){}

				[ElementInfo(0, "Period type code qualifier", "C", "1", "an..3", "" )]
public string E2023 { get; set; }
		[ElementInfo(1, "PERIOD DETAIL", "C", "1", "", "" )]
public C977 C977 { get; set; }

		
    }
}