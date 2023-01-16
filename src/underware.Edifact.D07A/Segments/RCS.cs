using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class RCS : Segment
    {
        public RCS() : base("RCS", "REQUIREMENTS AND CONDITIONS"){}

				[ElementInfo(0, "SECTOR AREA IDENTIFICATION CODE QUALIFIER", "Mandatory", "", "", "" )]
public string E7293 { get; set; }
		[ElementInfo(1, "REQUIREMENT/CONDITION IDENTIFICATION", "Conditional", "", "", "" )]
public C550 C550 { get; set; }
		[ElementInfo(2, "ACTION CODE", "Conditional", "", "", "" )]
public string E1229 { get; set; }
		[ElementInfo(3, "COUNTRY IDENTIFIER", "Conditional", "", "", "" )]
public string E3207 { get; set; }

		
    }
}