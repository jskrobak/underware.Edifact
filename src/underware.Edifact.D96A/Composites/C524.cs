using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D96A.Composites
{
    public class C524
    {
				[ElementInfo(0, "Handling instructions, coded", "C", "", "an..3", "" )]
public string E4079 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Handling instructions", "C", "", "an..70", "" )]
public string E4078 { get; set; }

    }
}