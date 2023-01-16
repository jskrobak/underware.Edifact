using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class LOC : Segment
    {
        public LOC() : base("LOC", "PLACE/LOCATION IDENTIFICATION"){}

				[ElementInfo(0, "LOCATION FUNCTION CODE QUALIFIER", "Mandatory", "", "", "" )]
public string E3227 { get; set; }
		[ElementInfo(1, "LOCATION IDENTIFICATION", "Conditional", "", "", "" )]
public C517 C517 { get; set; }
		[ElementInfo(2, "RELATED LOCATION ONE IDENTIFICATION", "Conditional", "", "", "" )]
public C519 C519 { get; set; }
		[ElementInfo(3, "RELATED LOCATION TWO IDENTIFICATION", "Conditional", "", "", "" )]
public C553 C553 { get; set; }
		[ElementInfo(4, "RELATION CODE", "Conditional", "", "", "" )]
public string E5479 { get; set; }

		
    }
}