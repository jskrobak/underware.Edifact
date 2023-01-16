using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C214
    {
				[ElementInfo(0, "Special service description code", "Conditional", "", "", "" )]
public string E7161 { get; set; }
		[ElementInfo(1, "Code list identification code", "Conditional", "", "", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "Conditional", "", "", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Special service description", "Conditional", "", "", "" )]
public string E7160 { get; set; }
		[ElementInfo(4, "Special service description", "Conditional", "", "", "" )]
public string E7160_0 { get; set; }

    }
}