using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02A.Composites;

namespace underware.Edifact.D02A.Segments
{
    public class RNG : Segment
    {
        public RNG() : base("RNG", "Range details"){}

				[ElementInfo(0, "Range type code qualifier", "M", "1", "an..3", "" )]
public string E6167 { get; set; }
		[ElementInfo(1, "RANGE", "C", "1", "", "" )]
public C280 C280 { get; set; }

		
    }
}