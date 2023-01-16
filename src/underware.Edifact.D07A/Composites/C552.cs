using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C552
    {
				[ElementInfo(0, "Allowance or charge identifier", "Conditional", "", "", "" )]
public string E1230 { get; set; }
		[ElementInfo(1, "Allowance or charge identification code", "Conditional", "", "", "" )]
public string E5189 { get; set; }

    }
}