using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C040
    {
				[ElementInfo(0, "Carrier identifier", "Conditional", "", "", "" )]
public string E3127 { get; set; }
		[ElementInfo(1, "Code list identification code", "Conditional", "", "", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "Conditional", "", "", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Carrier name", "Conditional", "", "", "" )]
public string E3126 { get; set; }

    }
}