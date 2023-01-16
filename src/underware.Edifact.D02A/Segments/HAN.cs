using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02A.Composites;

namespace underware.Edifact.D02A.Segments
{
    public class HAN : Segment
    {
        public HAN() : base("HAN", "Handling instructions"){}

				[ElementInfo(0, "HANDLING INSTRUCTIONS", "C", "1", "", "" )]
public C524 C524 { get; set; }
		[ElementInfo(1, "HAZARDOUS MATERIAL", "C", "1", "", "" )]
public C218 C218 { get; set; }

		
    }
}