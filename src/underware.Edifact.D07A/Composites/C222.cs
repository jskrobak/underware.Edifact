using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C222
    {
				[ElementInfo(0, "Transport means identification name identifier", "Conditional", "", "", "" )]
public string E8213 { get; set; }
		[ElementInfo(1, "Code list identification code", "Conditional", "", "", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "Conditional", "", "", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Transport means identification name", "Conditional", "", "", "" )]
public string E8212 { get; set; }
		[ElementInfo(4, "Transport means nationality code", "Conditional", "", "", "" )]
public string E8453 { get; set; }

    }
}