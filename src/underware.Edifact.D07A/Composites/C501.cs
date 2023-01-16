using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C501
    {
				[ElementInfo(0, "Percentage type code qualifier", "Mandatory", "", "", "" )]
public string E5245 { get; set; }
		[ElementInfo(1, "Percentage", "Conditional", "", "", "" )]
public string E5482 { get; set; }
		[ElementInfo(2, "Percentage basis identification code", "Conditional", "", "", "" )]
public string E5249 { get; set; }
		[ElementInfo(3, "Code list identification code", "Conditional", "", "", "" )]
public string E1131 { get; set; }
		[ElementInfo(4, "Code list responsible agency code", "Conditional", "", "", "" )]
public string E3055 { get; set; }

    }
}