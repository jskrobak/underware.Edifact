using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D96B.Composites
{
    public class C042
    {
				[ElementInfo(0, "Nationality, coded", "C", "", "an..3", "" )]
public string E3293 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Nationality", "C", "", "a..35", "" )]
public string E3292 { get; set; }

    }
}