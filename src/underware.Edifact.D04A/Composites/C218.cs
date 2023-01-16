using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04A.Composites
{
    public class C218
    {
				[ElementInfo(0, "Hazardous material category name code", "C", "", "an..7", "" )]
public string E7419 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Hazardous material category name", "C", "", "an..35", "" )]
public string E7418 { get; set; }

    }
}