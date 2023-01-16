using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C186
    {
				[ElementInfo(0, "Quantity type code qualifier", "Mandatory", "", "", "" )]
public string E6063 { get; set; }
		[ElementInfo(1, "Quantity", "Mandatory", "", "", "" )]
public string E6060 { get; set; }
		[ElementInfo(2, "Measurement unit code", "Conditional", "", "", "" )]
public string E6411 { get; set; }

    }
}