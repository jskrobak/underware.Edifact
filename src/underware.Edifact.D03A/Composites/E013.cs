using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03A.Composites
{
    public class E013
    {
				[ElementInfo(0, "Date or time or period function code qualifier", "M", "", "an..3", "" )]
public string E2005 { get; set; }
		[ElementInfo(1, "Date or time or period text", "M", "", "an..35", "" )]
public string E2380 { get; set; }
		[ElementInfo(2, "Date or time or period format code", "C", "", "an..3", "" )]
public string E2379 { get; set; }
		[ElementInfo(3, "Free text", "C", "", "an..512", "" )]
public string E4440 { get; set; }

    }
}