
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00A.Composites
{
    public class C237
    {
				[ElementInfo(0, "Equipment identifier", "C", "", "an..17", "" )]
public string E8260 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Country name code", "C", "", "an..3", "" )]
public string E3207 { get; set; }

    }
}