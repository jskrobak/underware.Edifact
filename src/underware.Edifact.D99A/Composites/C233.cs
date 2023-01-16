using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class C233
    {
				[ElementInfo(0, "Service requirement, coded", "M", "", "an..3", "" )]
public string E7273 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Service requirement, coded", "C", "", "an..3", "" )]
public string E7273_0 { get; set; }
		[ElementInfo(4, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131_0 { get; set; }
		[ElementInfo(5, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055_0 { get; set; }

    }
}