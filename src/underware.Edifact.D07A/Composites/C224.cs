using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C224
    {
				[ElementInfo(0, "Equipment size and type description code", "Conditional", "", "", "" )]
public string E8155 { get; set; }
		[ElementInfo(1, "Code list identification code", "Conditional", "", "", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "Conditional", "", "", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Equipment size and type description", "Conditional", "", "", "" )]
public string E8154 { get; set; }

    }
}