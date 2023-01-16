using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D95B.Composites
{
    public class C241
    {
				[ElementInfo(0, "Duty/tax/fee type, coded", "C", "", "an..3", "" )]
public string E5153 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Duty/tax/fee type", "C", "", "an..35", "" )]
public string E5152 { get; set; }

    }
}