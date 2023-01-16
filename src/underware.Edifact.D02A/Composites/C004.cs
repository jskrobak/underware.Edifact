using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02A.Composites
{
    public class C004
    {
				[ElementInfo(0, "Event category description code", "C", "", "an..3", "" )]
public string E9637 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Event category description", "C", "", "an..70", "" )]
public string E9636 { get; set; }

    }
}