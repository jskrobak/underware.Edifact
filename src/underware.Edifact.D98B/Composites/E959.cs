using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class E959
    {
				[ElementInfo(0, "Special services, coded", "M", "", "an..3", "" )]
public string E7161 { get; set; }
		[ElementInfo(1, "Time", "C", "", "n4", "" )]
public string E2002 { get; set; }
		[ElementInfo(2, "Time", "C", "", "n4", "" )]
public string E2002_0 { get; set; }
		[ElementInfo(3, "Date", "C", "", "an..14", "" )]
public string E2000 { get; set; }
		[ElementInfo(4, "Place/location", "C", "", "an..70", "" )]
public string E3224 { get; set; }

    }
}