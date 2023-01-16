using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C519
    {
				[ElementInfo(0, "First related location identifier", "Conditional", "", "", "" )]
public string E3223 { get; set; }
		[ElementInfo(1, "Code list identification code", "Conditional", "", "", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "Conditional", "", "", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "First related location name", "Conditional", "", "", "" )]
public string E3222 { get; set; }

    }
}