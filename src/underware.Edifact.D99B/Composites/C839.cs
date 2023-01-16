using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class C839
    {
				[ElementInfo(0, "Attendee category description code", "C", "", "an..3", "" )]
public string E7459 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Attendee category description", "C", "", "an..35", "" )]
public string E7458 { get; set; }

    }
}