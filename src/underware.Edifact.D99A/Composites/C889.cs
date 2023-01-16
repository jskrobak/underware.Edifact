using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class C889
    {
				[ElementInfo(0, "Characteristic value, coded", "C", "", "an..3", "" )]
public string E7111 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Characteristic value", "C", "", "an..35", "" )]
public string E7110 { get; set; }
		[ElementInfo(4, "Characteristic value", "C", "", "an..35", "" )]
public string E7110_0 { get; set; }

    }
}