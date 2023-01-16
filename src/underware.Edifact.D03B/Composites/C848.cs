using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03B.Composites
{
    public class C848
    {
				[ElementInfo(0, "Measurement unit code", "C", "", "an..8", "" )]
public string E6411 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Measurement unit name", "C", "", "an..35", "" )]
public string E6410 { get; set; }

    }
}