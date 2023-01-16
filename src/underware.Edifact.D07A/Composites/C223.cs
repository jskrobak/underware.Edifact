using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C223
    {
				[ElementInfo(0, "Shipment flashpoint degree", "Conditional", "", "", "" )]
public string E7106 { get; set; }
		[ElementInfo(1, "Measurement unit code", "Conditional", "", "", "" )]
public string E6411 { get; set; }

    }
}