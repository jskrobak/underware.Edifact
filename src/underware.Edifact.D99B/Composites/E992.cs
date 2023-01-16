using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class E992
    {
				[ElementInfo(0, "Related place/location one identification", "C", "", "an..25", "" )]
public string E3223 { get; set; }
		[ElementInfo(1, "Related place/location two identification", "C", "", "an..25", "" )]
public string E3233 { get; set; }

    }
}