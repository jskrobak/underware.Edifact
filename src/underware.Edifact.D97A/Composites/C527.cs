using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D97A.Composites
{
    public class C527
    {
				[ElementInfo(0, "Measurement value", "C", "", "an..18", "" )]
public string E6314 { get; set; }
		[ElementInfo(1, "Measure unit qualifier", "C", "", "an..3", "" )]
public string E6411 { get; set; }
		[ElementInfo(2, "Property measured, coded", "C", "", "an..3", "" )]
public string E6313 { get; set; }
		[ElementInfo(3, "Measurement significance, coded", "C", "", "an..3", "" )]
public string E6321 { get; set; }

    }
}