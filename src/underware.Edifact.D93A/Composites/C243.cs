using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D93A.Composites
{
    public class C243
    {
				[ElementInfo(0, "Duty/tax/fee rate identification", "C", "", "an..7", "" )]
public string E5279 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Duty/tax/fee rate", "C", "", "an..17", "" )]
public string E5278 { get; set; }
		[ElementInfo(4, "Duty/tax/fee rate basis identification", "C", "", "an..12", "" )]
public string E5273 { get; set; }
		[ElementInfo(5, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131_0 { get; set; }
		[ElementInfo(6, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055_0 { get; set; }

    }
}