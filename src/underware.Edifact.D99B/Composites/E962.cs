using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class E962
    {
				[ElementInfo(0, "Gate identification", "C", "", "an..6", "" )]
public string E3463 { get; set; }
		[ElementInfo(1, "Related place/location one identification", "C", "", "an..25", "" )]
public string E3223 { get; set; }
		[ElementInfo(2, "Related place/location one identification", "C", "", "an..25", "" )]
public string E3223_0 { get; set; }

    }
}