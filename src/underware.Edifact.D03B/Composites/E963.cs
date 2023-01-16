using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03B.Composites
{
    public class E963
    {
				[ElementInfo(0, "Measure", "C", "", "an..18", "" )]
public string E6314 { get; set; }
		[ElementInfo(1, "Measurement unit code", "C", "", "an..8", "" )]
public string E6411 { get; set; }
		[ElementInfo(2, "Time", "C", "", "n4", "" )]
public string E2002 { get; set; }

    }
}