using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98A.Composites
{
    public class E011
    {
				[ElementInfo(0, "Rate/tariff class identification", "M", "", "an..9", "" )]
public string E5243 { get; set; }
		[ElementInfo(1, "Processing indicator, coded", "C", "", "an..3", "" )]
public string E7365 { get; set; }

    }
}