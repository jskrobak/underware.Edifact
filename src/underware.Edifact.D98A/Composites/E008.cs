using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98A.Composites
{
    public class E008
    {
				[ElementInfo(0, "Place/location qualifier", "M", "", "an..3", "" )]
public string E3227 { get; set; }
		[ElementInfo(1, "Place/location", "M", "", "an..70", "" )]
public string E3224 { get; set; }
		[ElementInfo(2, "Relation, coded", "C", "", "an..3", "" )]
public string E5479 { get; set; }
		[ElementInfo(3, "Quantity", "C", "", "n..15", "" )]
public string E6060 { get; set; }
		[ElementInfo(4, "Quantity qualifier", "C", "", "an..3", "" )]
public string E6063 { get; set; }
		[ElementInfo(5, "Time", "C", "", "n4", "" )]
public string E2002 { get; set; }
		[ElementInfo(6, "Type of means of transport identification", "C", "", "an..8", "" )]
public string E8179 { get; set; }
		[ElementInfo(7, "Type of means of transport identification", "C", "", "an..8", "" )]
public string E8179_0 { get; set; }
		[ElementInfo(8, "Type of means of transport identification", "C", "", "an..8", "" )]
public string E8179_1 { get; set; }
		[ElementInfo(9, "Type of means of transport identification", "C", "", "an..8", "" )]
public string E8179_2 { get; set; }
		[ElementInfo(10, "Type of means of transport identification", "C", "", "an..8", "" )]
public string E8179_3 { get; set; }

    }
}