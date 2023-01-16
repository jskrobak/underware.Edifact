using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D96A.Composites
{
    public class C515
    {
				[ElementInfo(0, "Test reason identification", "C", "", "an..17", "" )]
public string E4425 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Test reason", "C", "", "an..35", "" )]
public string E4424 { get; set; }

    }
}