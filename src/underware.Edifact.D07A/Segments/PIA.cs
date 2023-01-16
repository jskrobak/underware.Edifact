using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class PIA : Segment
    {
        public PIA() : base("PIA", "ADDITIONAL PRODUCT ID"){}

				[ElementInfo(0, "PRODUCT IDENTIFIER CODE QUALIFIER", "Mandatory", "", "", "" )]
public string E4347 { get; set; }
		[ElementInfo(1, "ITEM NUMBER IDENTIFICATION", "Mandatory", "", "", "" )]
public C212 C212 { get; set; }
		[ElementInfo(2, "ITEM NUMBER IDENTIFICATION", "Conditional", "", "", "" )]
public C212 C212_0 { get; set; }
		[ElementInfo(3, "ITEM NUMBER IDENTIFICATION", "Conditional", "", "", "" )]
public C212 C212_1 { get; set; }
		[ElementInfo(4, "ITEM NUMBER IDENTIFICATION", "Conditional", "", "", "" )]
public C212 C212_2 { get; set; }
		[ElementInfo(5, "ITEM NUMBER IDENTIFICATION", "Conditional", "", "", "" )]
public C212 C212_3 { get; set; }

		
    }
}