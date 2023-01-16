using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D93A.Composites
{
    public class C507
    {
				[ElementInfo(0, "Date/time/period qualifier", "M", "", "an..3", "" )]
public string E2005 { get; set; }
		[ElementInfo(1, "Date/time/period", "C", "", "an..35", "" )]
public string E2380 { get; set; }
		[ElementInfo(2, "Date/time/period format qualifier", "C", "", "an..3", "" )]
public string E2379 { get; set; }

    }
}