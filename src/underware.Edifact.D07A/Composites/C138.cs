using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C138
    {
				[ElementInfo(0, "Price multiplier rate", "Mandatory", "", "", "" )]
public string E5394 { get; set; }
		[ElementInfo(1, "Price multiplier type code qualifier", "Conditional", "", "", "" )]
public string E5393 { get; set; }

    }
}