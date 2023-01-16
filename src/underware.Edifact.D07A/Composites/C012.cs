using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C012
    {
				[ElementInfo(0, "Processing indicator description code", "Conditional", "", "", "" )]
public string E7365 { get; set; }
		[ElementInfo(1, "Code list identification code", "Conditional", "", "", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "Conditional", "", "", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Processing indicator description", "Conditional", "", "", "" )]
public string E7364 { get; set; }

    }
}