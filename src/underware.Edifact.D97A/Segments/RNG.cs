using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97A.Composites;

namespace underware.Edifact.D97A.Segments
{
    public class RNG : Segment
    {
        public RNG() : base("RNG", "Range details"){}

				[ElementInfo(0, "Range type qualifier", "M", "1", "an..3", "" )]
public string E6167 { get; set; }
		[ElementInfo(1, "RANGE", "C", "1", "", "" )]
public C280 C280 { get; set; }

		
    }
}