using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class E013
    {
				[ElementInfo(0, "Date/time/period qualifier", "M", "", "an..3", "" )]
public string E2005 { get; set; }
		[ElementInfo(1, "Date/time/period", "M", "", "an..35", "" )]
public string E2380 { get; set; }
		[ElementInfo(2, "Date/time/period format qualifier", "C", "", "an..3", "" )]
public string E2379 { get; set; }
		[ElementInfo(3, "Free text", "C", "", "an..70", "" )]
public string E4440 { get; set; }

    }
}