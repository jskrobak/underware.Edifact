using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D96B.Composites
{
    public class C550
    {
				[ElementInfo(0, "Requirement/condition identification", "M", "", "an..17", "" )]
public string E7295 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Requirement or condition", "C", "", "an..35", "" )]
public string E7294 { get; set; }

    }
}