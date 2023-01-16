using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C516
    {
				[ElementInfo(0, "Monetary amount type code qualifier", "Mandatory", "", "", "" )]
public string E5025 { get; set; }
		[ElementInfo(1, "Monetary amount", "Conditional", "", "", "" )]
public string E5004 { get; set; }
		[ElementInfo(2, "Currency identification code", "Conditional", "", "", "" )]
public string E6345 { get; set; }
		[ElementInfo(3, "Currency type code qualifier", "Conditional", "", "", "" )]
public string E6343 { get; set; }
		[ElementInfo(4, "Status description code", "Conditional", "", "", "" )]
public string E4405 { get; set; }

    }
}