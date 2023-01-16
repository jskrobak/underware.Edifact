using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03B.Composites
{
    public class C595
    {
				[ElementInfo(0, "Accounting journal identifier", "M", "", "an..17", "" )]
public string E1171 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Accounting journal name", "C", "", "an..35", "" )]
public string E1170 { get; set; }

    }
}