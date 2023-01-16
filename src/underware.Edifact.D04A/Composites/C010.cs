using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04A.Composites
{
    public class C010
    {
				[ElementInfo(0, "Information type description code", "C", "", "an..3", "" )]
public string E9613 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Information type description", "C", "", "an..70", "" )]
public string E9612 { get; set; }

    }
}