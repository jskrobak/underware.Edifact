using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02A.Composites
{
    public class C816
    {
				[ElementInfo(0, "Name component type code qualifier", "M", "", "an..3", "" )]
public string E3405 { get; set; }
		[ElementInfo(1, "Name component description", "C", "", "an..70", "" )]
public string E3398 { get; set; }
		[ElementInfo(2, "Name component usage code", "C", "", "an..3", "" )]
public string E3401 { get; set; }
		[ElementInfo(3, "Name original alphabet code", "C", "", "an..3", "" )]
public string E3295 { get; set; }

    }
}