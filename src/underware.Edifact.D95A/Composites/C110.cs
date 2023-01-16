using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D95A.Composites
{
    public class C110
    {
				[ElementInfo(0, "Terms of payment identification", "M", "", "an..17", "" )]
public string E4277 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Terms of payment", "C", "", "an..35", "" )]
public string E4276 { get; set; }
		[ElementInfo(4, "Terms of payment", "C", "", "an..35", "" )]
public string E4276_0 { get; set; }

    }
}