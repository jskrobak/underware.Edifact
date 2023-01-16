using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class ALC : Segment
    {
        public ALC() : base("ALC", "ALLOWANCE OR CHARGE"){}

				[ElementInfo(0, "ALLOWANCE OR CHARGE CODE QUALIFIER", "Mandatory", "", "", "" )]
public string E5463 { get; set; }
		[ElementInfo(1, "ALLOWANCE/CHARGE INFORMATION", "Conditional", "", "", "" )]
public C552 C552 { get; set; }
		[ElementInfo(2, "SETTLEMENT MEANS CODE", "Conditional", "", "", "" )]
public string E4471 { get; set; }
		[ElementInfo(3, "CALCULATION SEQUENCE CODE", "Conditional", "", "", "" )]
public string E1227 { get; set; }
		[ElementInfo(4, "SPECIAL SERVICES IDENTIFICATION", "Conditional", "", "", "" )]
public C214 C214 { get; set; }

		
    }
}