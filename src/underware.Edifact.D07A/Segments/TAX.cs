using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class TAX : Segment
    {
        public TAX() : base("TAX", "DUTY/TAX/FEE DETAILS"){}

				[ElementInfo(0, "DUTY OR TAX OR FEE FUNCTION CODE QUALIFIER", "Mandatory", "", "", "" )]
public string E5283 { get; set; }
		[ElementInfo(1, "DUTY/TAX/FEE TYPE", "Conditional", "", "", "" )]
public C241 C241 { get; set; }
		[ElementInfo(2, "DUTY/TAX/FEE ACCOUNT DETAIL", "Conditional", "", "", "" )]
public C533 C533 { get; set; }
		[ElementInfo(3, "DUTY OR TAX OR FEE ASSESSMENT BASIS QUANTITY", "Conditional", "", "", "" )]
public string E5286 { get; set; }
		[ElementInfo(4, "DUTY/TAX/FEE DETAIL", "Conditional", "", "", "" )]
public C243 C243 { get; set; }
		[ElementInfo(5, "DUTY OR TAX OR FEE CATEGORY CODE", "Conditional", "", "", "" )]
public string E5305 { get; set; }
		[ElementInfo(6, "PARTY TAX IDENTIFIER", "Conditional", "", "", "" )]
public string E3446 { get; set; }
		[ElementInfo(7, "CALCULATION SEQUENCE CODE", "Conditional", "", "", "" )]
public string E1227 { get; set; }
		[ElementInfo(8, "TAX OR DUTY OR FEE PAYMENT DUE DATE CODE", "Conditional", "", "", "" )]
public string E5307 { get; set; }

		
    }
}