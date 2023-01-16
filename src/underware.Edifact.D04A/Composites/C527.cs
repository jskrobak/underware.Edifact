using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04A.Composites
{
    public class C527
    {
				[ElementInfo(0, "Measure", "C", "", "an..18", "" )]
public string E6314 { get; set; }
		[ElementInfo(1, "Measurement unit code", "C", "", "an..8", "" )]
public string E6411 { get; set; }
		[ElementInfo(2, "Measured attribute code", "C", "", "an..3", "" )]
public string E6313 { get; set; }
		[ElementInfo(3, "Measurement significance code", "C", "", "an..3", "" )]
public string E6321 { get; set; }

    }
}