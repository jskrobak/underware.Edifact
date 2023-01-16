using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98A.Composites
{
    public class C200
    {
				[ElementInfo(0, "Freight and charges identification", "C", "", "an..17", "" )]
public string E8023 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Freight and charges", "C", "", "an..26", "" )]
public string E8022 { get; set; }
		[ElementInfo(4, "Prepaid/collect indicator, coded", "C", "", "an..3", "" )]
public string E4237 { get; set; }
		[ElementInfo(5, "Item number", "C", "", "an..35", "" )]
public string E7140 { get; set; }

    }
}