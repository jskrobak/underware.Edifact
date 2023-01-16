using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class E020
    {
				[ElementInfo(0, "Duty/tax/fee type name code", "M", "", "an..3", "" )]
public string E5153 { get; set; }
		[ElementInfo(1, "Monetary amount value", "C", "", "n..35", "" )]
public string E5004 { get; set; }
		[ElementInfo(2, "Duty/tax/fee rate", "C", "", "an..17", "" )]
public string E5278 { get; set; }

    }
}