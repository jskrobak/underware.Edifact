using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C819
    {
				[ElementInfo(0, "Country subdivision identifier", "Conditional", "", "", "" )]
public string E3229 { get; set; }
		[ElementInfo(1, "Code list identification code", "Conditional", "", "", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "Conditional", "", "", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Country subdivision name", "Conditional", "", "", "" )]
public string E3228 { get; set; }

    }
}