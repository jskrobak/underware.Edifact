
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00A.Composites
{
    public class C079
    {
				[ElementInfo(0, "Computer environment name code", "C", "", "an..3", "" )]
public string E1511 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Computer environment name", "C", "", "an..35", "" )]
public string E1510 { get; set; }
		[ElementInfo(4, "Version identifier", "C", "", "an..9", "" )]
public string E1056 { get; set; }
		[ElementInfo(5, "Release identifier", "C", "", "an..9", "" )]
public string E1058 { get; set; }
		[ElementInfo(6, "Object identifier", "C", "", "an..35", "" )]
public string E7402 { get; set; }

    }
}