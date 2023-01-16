using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04B.Composites
{
    public class C942
    {
				[ElementInfo(0, "Membership category description code", "M", "", "an..4", "" )]
public string E7451 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Membership category description", "C", "", "an..35", "" )]
public string E7450 { get; set; }

    }
}