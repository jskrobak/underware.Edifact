using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C100
    {
				[ElementInfo(0, "Delivery or transport terms description code", "Conditional", "", "", "" )]
public string E4053 { get; set; }
		[ElementInfo(1, "Code list identification code", "Conditional", "", "", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "Conditional", "", "", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Delivery or transport terms description", "Conditional", "", "", "" )]
public string E4052 { get; set; }
		[ElementInfo(4, "Delivery or transport terms description", "Conditional", "", "", "" )]
public string E4052_0 { get; set; }

    }
}