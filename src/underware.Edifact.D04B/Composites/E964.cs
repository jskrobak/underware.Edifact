using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04B.Composites
{
    public class E964
    {
				[ElementInfo(0, "Time", "C", "", "n4", "" )]
public string E2002 { get; set; }
		[ElementInfo(1, "Time", "C", "", "n4", "" )]
public string E2002_0 { get; set; }
		[ElementInfo(2, "Check-in time", "C", "", "an..10", "" )]
public string E2156 { get; set; }

    }
}