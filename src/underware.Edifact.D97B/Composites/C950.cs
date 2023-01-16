using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D97B.Composites
{
    public class C950
    {
				[ElementInfo(0, "Qualification classification, coded", "C", "", "an..3", "" )]
public string E9007 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Qualification classification", "C", "", "an..35", "" )]
public string E9006 { get; set; }
		[ElementInfo(4, "Qualification classification", "C", "", "an..35", "" )]
public string E9006_0 { get; set; }

    }
}