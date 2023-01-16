using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D94B.Composites
{
    public class C231
    {
				[ElementInfo(0, "Transport charges method of payment, coded", "M", "", "an..3", "" )]
public string E4215 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }

    }
}