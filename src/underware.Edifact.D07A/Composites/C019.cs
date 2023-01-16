using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C019
    {
				[ElementInfo(0, "Payment terms description identifier", "Conditional", "", "", "" )]
public string E4277 { get; set; }
		[ElementInfo(1, "Code list identification code", "Conditional", "", "", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "Conditional", "", "", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Payment terms description", "Conditional", "", "", "" )]
public string E4276 { get; set; }

    }
}