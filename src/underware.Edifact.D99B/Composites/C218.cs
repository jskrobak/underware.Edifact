using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class C218
    {
				[ElementInfo(0, "Hazardous material class code, identification", "C", "", "an..4", "" )]
public string E7419 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Hazardous material class", "C", "", "an..35", "" )]
public string E7418 { get; set; }

    }
}