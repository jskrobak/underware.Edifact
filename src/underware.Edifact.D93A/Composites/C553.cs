using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D93A.Composites
{
    public class C553
    {
				[ElementInfo(0, "Related place/location two identification", "C", "", "an..25", "" )]
public string E3233 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Related place/location two", "C", "", "an..70", "" )]
public string E3232 { get; set; }

    }
}