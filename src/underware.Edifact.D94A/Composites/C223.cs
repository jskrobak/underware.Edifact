using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D94A.Composites
{
    public class C223
    {
				[ElementInfo(0, "Shipment flashpoint", "C", "", "n3", "" )]
public string E7106 { get; set; }
		[ElementInfo(1, "Measure unit qualifier", "C", "", "an..3", "" )]
public string E6411 { get; set; }

    }
}