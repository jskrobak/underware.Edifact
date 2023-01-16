using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class C507
    {
				[ElementInfo(0, "Date/time/period function code qualifier", "M", "", "an..3", "" )]
public string E2005 { get; set; }
		[ElementInfo(1, "Date/time/period value", "C", "", "an..35", "" )]
public string E2380 { get; set; }
		[ElementInfo(2, "Date/time/period format code", "C", "", "an..3", "" )]
public string E2379 { get; set; }

    }
}