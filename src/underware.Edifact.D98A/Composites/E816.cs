using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98A.Composites
{
    public class E816
    {
				[ElementInfo(0, "Name component qualifier", "M", "", "an..3", "" )]
public string E3405 { get; set; }
		[ElementInfo(1, "Name component", "C", "", "an..70", "" )]
public string E3398 { get; set; }
		[ElementInfo(2, "Name component status, coded", "C", "", "an..3", "" )]
public string E3401 { get; set; }
		[ElementInfo(3, "Name component original representation, coded", "C", "", "an..3", "" )]
public string E3295 { get; set; }

    }
}