using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C288
    {
				[ElementInfo(0, "Product group name code", "Conditional", "", "", "" )]
public string E5389 { get; set; }
		[ElementInfo(1, "Code list identification code", "Conditional", "", "", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "Conditional", "", "", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Product group name", "Conditional", "", "", "" )]
public string E5388 { get; set; }

    }
}