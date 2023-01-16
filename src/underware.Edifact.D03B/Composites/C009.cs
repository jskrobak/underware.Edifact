using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03B.Composites
{
    public class C009
    {
				[ElementInfo(0, "Information category description code", "C", "", "an..3", "" )]
public string E9615 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Information category description", "C", "", "an..70", "" )]
public string E9614 { get; set; }

    }
}