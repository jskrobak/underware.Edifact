using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C553
    {
				[ElementInfo(0, "Second related location identifier", "Conditional", "", "", "" )]
public string E3233 { get; set; }
		[ElementInfo(1, "Code list identification code", "Conditional", "", "", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "Conditional", "", "", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Second related location name", "Conditional", "", "", "" )]
public string E3232 { get; set; }

    }
}