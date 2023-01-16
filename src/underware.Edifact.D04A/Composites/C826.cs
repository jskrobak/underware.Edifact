using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04A.Composites
{
    public class C826
    {
				[ElementInfo(0, "Action request/notification description code", "C", "", "an..3", "" )]
public string E1229 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Action request/notification description", "C", "", "an..35", "" )]
public string E1228 { get; set; }

    }
}