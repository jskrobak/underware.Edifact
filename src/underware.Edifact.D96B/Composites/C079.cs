using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D96B.Composites
{
    public class C079
    {
				[ElementInfo(0, "Computer environment, coded", "C", "", "an..3", "" )]
public string E1511 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Computer environment", "C", "", "an..35", "" )]
public string E1510 { get; set; }
		[ElementInfo(4, "Version", "C", "", "an..9", "" )]
public string E1056 { get; set; }
		[ElementInfo(5, "Release", "C", "", "an..9", "" )]
public string E1058 { get; set; }
		[ElementInfo(6, "Identity number", "C", "", "an..35", "" )]
public string E7402 { get; set; }

    }
}