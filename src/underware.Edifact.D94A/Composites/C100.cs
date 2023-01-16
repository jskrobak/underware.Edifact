using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D94A.Composites
{
    public class C100
    {
				[ElementInfo(0, "Terms of delivery, coded", "C", "", "an..3", "" )]
public string E4053 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Terms of delivery", "C", "", "an..70", "" )]
public string E4052 { get; set; }
		[ElementInfo(4, "Terms of delivery", "C", "", "an..70", "" )]
public string E4052_0 { get; set; }

    }
}