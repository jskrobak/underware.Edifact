using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02A.Composites
{
    public class E008
    {
				[ElementInfo(0, "Location function code qualifier", "M", "", "an..3", "" )]
public string E3227 { get; set; }
		[ElementInfo(1, "Location name", "M", "", "an..256", "" )]
public string E3224 { get; set; }
		[ElementInfo(2, "Relation code", "C", "", "an..3", "" )]
public string E5479 { get; set; }
		[ElementInfo(3, "Quantity", "C", "", "an..35", "" )]
public string E6060 { get; set; }
		[ElementInfo(4, "Quantity type code qualifier", "C", "", "an..3", "" )]
public string E6063 { get; set; }
		[ElementInfo(5, "Time", "C", "", "n4", "" )]
public string E2002 { get; set; }
		[ElementInfo(6, "Transport means description code", "C", "", "an..8", "" )]
public string E8179 { get; set; }
		[ElementInfo(7, "Transport means description code", "C", "", "an..8", "" )]
public string E8179_0 { get; set; }
		[ElementInfo(8, "Transport means description code", "C", "", "an..8", "" )]
public string E8179_1 { get; set; }
		[ElementInfo(9, "Transport means description code", "C", "", "an..8", "" )]
public string E8179_2 { get; set; }
		[ElementInfo(10, "Transport means description code", "C", "", "an..8", "" )]
public string E8179_3 { get; set; }
		[ElementInfo(11, "Latitude degree", "C", "", "an..10", "" )]
public string E6000 { get; set; }
		[ElementInfo(12, "Longitude degree", "C", "", "an..11", "" )]
public string E6002 { get; set; }

    }
}