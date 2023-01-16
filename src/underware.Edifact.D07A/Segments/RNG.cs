using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class RNG : Segment
    {
        public RNG() : base("RNG", "RANGE DETAILS"){}

				[ElementInfo(0, "RANGE TYPE CODE QUALIFIER", "Mandatory", "", "", "" )]
public string E6167 { get; set; }
		[ElementInfo(1, "RANGE", "Conditional", "", "", "" )]
public C280 C280 { get; set; }

		
    }
}