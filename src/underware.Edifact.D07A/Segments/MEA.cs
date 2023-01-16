using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class MEA : Segment
    {
        public MEA() : base("MEA", "MEASUREMENTS"){}

				[ElementInfo(0, "MEASUREMENT PURPOSE CODE QUALIFIER", "Mandatory", "", "", "" )]
public string E6311 { get; set; }
		[ElementInfo(1, "MEASUREMENT DETAILS", "Conditional", "", "", "" )]
public C502 C502 { get; set; }
		[ElementInfo(2, "VALUE/RANGE", "Conditional", "", "", "" )]
public C174 C174 { get; set; }
		[ElementInfo(3, "SURFACE OR LAYER CODE", "Conditional", "", "", "" )]
public string E7383 { get; set; }

		
    }
}