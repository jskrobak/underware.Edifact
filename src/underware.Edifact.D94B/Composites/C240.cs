using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D94B.Composites
{
    public class C240
    {
				[ElementInfo(0, "Characteristic identification", "M", "", "an..17", "" )]
public string E7037 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Characteristic", "C", "", "an..35", "" )]
public string E7036 { get; set; }
		[ElementInfo(4, "Characteristic", "C", "", "an..35", "" )]
public string E7036_0 { get; set; }

    }
}