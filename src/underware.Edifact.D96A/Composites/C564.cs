using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D96A.Composites
{
    public class C564
    {
				[ElementInfo(0, "Physical or logical state, coded", "C", "", "an..3", "" )]
public string E7007 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Physical or logical state", "C", "", "an..35", "" )]
public string E7006 { get; set; }

    }
}