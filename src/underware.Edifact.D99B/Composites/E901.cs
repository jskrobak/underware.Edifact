using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class E901
    {
				[ElementInfo(0, "Application error identification", "M", "", "an..8", "" )]
public string E9321 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }

    }
}