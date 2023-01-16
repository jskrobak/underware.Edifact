using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C241
    {
				[ElementInfo(0, "Duty or tax or fee type name code", "Conditional", "", "", "" )]
public string E5153 { get; set; }
		[ElementInfo(1, "Code list identification code", "Conditional", "", "", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "Conditional", "", "", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Duty or tax or fee type name", "Conditional", "", "", "" )]
public string E5152 { get; set; }

    }
}