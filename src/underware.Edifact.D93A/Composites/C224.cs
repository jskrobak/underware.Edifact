using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D93A.Composites
{
    public class C224
    {
				[ElementInfo(0, "Equipment size and type identification", "C", "", "an..4", "" )]
public string E8155 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Equipment size and type", "C", "", "an..35", "" )]
public string E8154 { get; set; }

    }
}