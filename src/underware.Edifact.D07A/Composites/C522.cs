using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C522
    {
				[ElementInfo(0, "Instruction type code qualifier", "Mandatory", "", "", "" )]
public string E4403 { get; set; }
		[ElementInfo(1, "Instruction description code", "Conditional", "", "", "" )]
public string E4401 { get; set; }
		[ElementInfo(2, "Code list identification code", "Conditional", "", "", "" )]
public string E1131 { get; set; }
		[ElementInfo(3, "Code list responsible agency code", "Conditional", "", "", "" )]
public string E3055 { get; set; }
		[ElementInfo(4, "Instruction description", "Conditional", "", "", "" )]
public string E4400 { get; set; }

    }
}