using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C534
    {
				[ElementInfo(0, "Payment conditions code", "Conditional", "", "", "" )]
public string E4439 { get; set; }
		[ElementInfo(1, "Payment guarantee means code", "Conditional", "", "", "" )]
public string E4431 { get; set; }
		[ElementInfo(2, "Payment means code", "Conditional", "", "", "" )]
public string E4461 { get; set; }
		[ElementInfo(3, "Code list identification code", "Conditional", "", "", "" )]
public string E1131 { get; set; }
		[ElementInfo(4, "Code list responsible agency code", "Conditional", "", "", "" )]
public string E3055 { get; set; }
		[ElementInfo(5, "Payment channel code", "Conditional", "", "", "" )]
public string E4435 { get; set; }

    }
}