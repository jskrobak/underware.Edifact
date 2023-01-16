using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C550
    {
				[ElementInfo(0, "Requirement or condition description identifier", "Mandatory", "", "", "" )]
public string E7295 { get; set; }
		[ElementInfo(1, "Code list identification code", "Conditional", "", "", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "Conditional", "", "", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Requirement or condition description", "Conditional", "", "", "" )]
public string E7294 { get; set; }

    }
}