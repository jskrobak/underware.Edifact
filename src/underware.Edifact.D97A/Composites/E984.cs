using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D97A.Composites
{
    public class E984
    {
				[ElementInfo(0, "Charge unit, coded", "C", "", "an..3", "" )]
public string E5261 { get; set; }
		[ElementInfo(1, "Monetary amount", "C", "", "n..18", "" )]
public string E5004 { get; set; }
		[ElementInfo(2, "Item description", "C", "", "an..35", "" )]
public string E7008 { get; set; }
		[ElementInfo(3, "Quantity", "C", "", "n..15", "" )]
public string E6060 { get; set; }
		[ElementInfo(4, "Charge period type, coded", "C", "", "an..3", "" )]
public string E2155 { get; set; }
		[ElementInfo(5, "Currency, coded", "C", "", "an..3", "" )]
public string E6345 { get; set; }
		[ElementInfo(6, "Place/location identification", "C", "", "an..25", "" )]
public string E3225 { get; set; }
		[ElementInfo(7, "Free text", "C", "", "an..70", "" )]
public string E4440 { get; set; }

    }
}