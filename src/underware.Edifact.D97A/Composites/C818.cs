using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D97A.Composites
{
    public class C818
    {
				[ElementInfo(0, "Person inherited characteristic identification", "C", "", "an..8", "" )]
public string E3311 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Person inherited characteristic", "C", "", "an..70", "" )]
public string E3310 { get; set; }

    }
}