using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02A.Composites
{
    public class C222
    {
				[ElementInfo(0, "Transport means identification name identifier", "C", "", "an..9", "" )]
public string E8213 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Transport means identification name", "C", "", "an..35", "" )]
public string E8212 { get; set; }
		[ElementInfo(4, "Transport means nationality code", "C", "", "an..3", "" )]
public string E8453 { get; set; }

    }
}