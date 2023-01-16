using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03A.Composites
{
    public class C001
    {
				[ElementInfo(0, "Transport means description code", "C", "", "an..8", "" )]
public string E8179 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Transport means description", "C", "", "an..17", "" )]
public string E8178 { get; set; }

    }
}