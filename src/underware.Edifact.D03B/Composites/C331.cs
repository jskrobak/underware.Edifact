using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03B.Composites
{
    public class C331
    {
				[ElementInfo(0, "Insurance cover description code", "C", "", "an..17", "" )]
public string E4495 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Insurance cover description", "C", "", "an..35", "" )]
public string E4494 { get; set; }
		[ElementInfo(4, "Insurance cover description", "C", "", "an..35", "" )]
public string E4494_0 { get; set; }

    }
}