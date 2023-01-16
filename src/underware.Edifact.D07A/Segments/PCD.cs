using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class PCD : Segment
    {
        public PCD() : base("PCD", "PERCENTAGE DETAILS"){}

				[ElementInfo(0, "PERCENTAGE DETAILS", "Mandatory", "", "", "" )]
public C501 C501 { get; set; }
		[ElementInfo(1, "STATUS DESCRIPTION CODE", "Conditional", "", "", "" )]
public string E4405 { get; set; }

		
    }
}