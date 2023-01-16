using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C243
    {
				[ElementInfo(0, "Duty or tax or fee rate code", "Conditional", "", "", "" )]
public string E5279 { get; set; }
		[ElementInfo(1, "Code list identification code", "Conditional", "", "", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "Conditional", "", "", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Duty or tax or fee rate", "Conditional", "", "", "" )]
public string E5278 { get; set; }
		[ElementInfo(4, "Duty or tax or fee rate basis code", "Conditional", "", "", "" )]
public string E5273 { get; set; }
		[ElementInfo(5, "Code list identification code", "Conditional", "", "", "" )]
public string E1131_0 { get; set; }
		[ElementInfo(6, "Code list responsible agency code", "Conditional", "", "", "" )]
public string E3055_0 { get; set; }

    }
}