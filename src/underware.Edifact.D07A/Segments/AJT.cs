using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class AJT : Segment
    {
        public AJT() : base("AJT", "ADJUSTMENT DETAILS"){}

				[ElementInfo(0, "ADJUSTMENT REASON DESCRIPTION CODE", "Mandatory", "", "", "" )]
public string E4465 { get; set; }
		[ElementInfo(1, "LINE ITEM IDENTIFIER", "Conditional", "", "", "" )]
public string E1082 { get; set; }

		
    }
}