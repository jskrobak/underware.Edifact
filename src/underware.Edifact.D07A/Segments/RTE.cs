using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class RTE : Segment
    {
        public RTE() : base("RTE", "RATE DETAILS"){}

				[ElementInfo(0, "RATE DETAILS", "Mandatory", "", "", "" )]
public C128 C128 { get; set; }
		[ElementInfo(1, "STATUS DESCRIPTION CODE", "Conditional", "", "", "" )]
public string E4405 { get; set; }

		
    }
}