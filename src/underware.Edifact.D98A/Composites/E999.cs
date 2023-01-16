using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98A.Composites
{
    public class E999
    {
				[ElementInfo(0, "Place/location identification", "C", "", "an..25", "" )]
public string E3225 { get; set; }
		[ElementInfo(1, "Party name", "C", "", "an..35", "" )]
public string E3036 { get; set; }
		[ElementInfo(2, "Time", "C", "", "n4", "" )]
public string E2002 { get; set; }
		[ElementInfo(3, "Time", "C", "", "n4", "" )]
public string E2002_0 { get; set; }

    }
}