using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class FII : Segment
    {
        public FII() : base("FII", "FINANCIAL INSTITUTION INFORMATION"){}

				[ElementInfo(0, "PARTY FUNCTION CODE QUALIFIER", "Mandatory", "", "", "" )]
public string E3035 { get; set; }
		[ElementInfo(1, "ACCOUNT HOLDER IDENTIFICATION", "Conditional", "", "", "" )]
public C078 C078 { get; set; }
		[ElementInfo(2, "INSTITUTION IDENTIFICATION", "Conditional", "", "", "" )]
public C088 C088 { get; set; }
		[ElementInfo(3, "COUNTRY IDENTIFIER", "Conditional", "", "", "" )]
public string E3207 { get; set; }

		
    }
}