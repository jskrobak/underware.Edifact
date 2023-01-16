using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class C241
    {
				[ElementInfo(0, "Duty/tax/fee type name code", "C", "", "an..3", "" )]
public string E5153 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Duty/tax/fee type name", "C", "", "an..35", "" )]
public string E5152 { get; set; }

    }
}