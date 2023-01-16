using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C401
    {
				[ElementInfo(0, "Excess transportation reason code", "Mandatory", "", "", "" )]
public string E8457 { get; set; }
		[ElementInfo(1, "Excess transportation responsibility code", "Mandatory", "", "", "" )]
public string E8459 { get; set; }
		[ElementInfo(2, "Customer shipment authorisation identifier", "Conditional", "", "", "" )]
public string E7130 { get; set; }

    }
}