using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04B.Composites
{
    public class C401
    {
				[ElementInfo(0, "Excess transportation reason code", "M", "", "an..3", "" )]
public string E8457 { get; set; }
		[ElementInfo(1, "Excess transportation responsibility code", "M", "", "an..3", "" )]
public string E8459 { get; set; }
		[ElementInfo(2, "Customer shipment authorisation identifier", "C", "", "an..17", "" )]
public string E7130 { get; set; }

    }
}