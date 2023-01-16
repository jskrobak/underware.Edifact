using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class PYT : Segment
    {
        public PYT() : base("PYT", "PAYMENT TERMS"){}

				[ElementInfo(0, "PAYMENT TERMS TYPE CODE QUALIFIER", "Mandatory", "", "", "" )]
public string E4279 { get; set; }
		[ElementInfo(1, "PAYMENT TERMS", "Conditional", "", "", "" )]
public C019 C019 { get; set; }
		[ElementInfo(2, "EVENT TIME REFERENCE CODE", "Conditional", "", "", "" )]
public string E2475 { get; set; }
		[ElementInfo(3, "TERMS TIME RELATION CODE", "Conditional", "", "", "" )]
public string E2009 { get; set; }
		[ElementInfo(4, "PERIOD TYPE CODE", "Conditional", "", "", "" )]
public string E2151 { get; set; }
		[ElementInfo(5, "PERIOD COUNT QUANTITY", "Conditional", "", "", "" )]
public string E2152 { get; set; }

		
    }
}