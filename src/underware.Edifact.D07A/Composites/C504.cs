using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C504
    {
				[ElementInfo(0, "Currency usage code qualifier", "Mandatory", "", "", "" )]
public string E6347 { get; set; }
		[ElementInfo(1, "Currency identification code", "Conditional", "", "", "" )]
public string E6345 { get; set; }
		[ElementInfo(2, "Currency type code qualifier", "Conditional", "", "", "" )]
public string E6343 { get; set; }
		[ElementInfo(3, "Currency rate", "Conditional", "", "", "" )]
public string E6348 { get; set; }

    }
}