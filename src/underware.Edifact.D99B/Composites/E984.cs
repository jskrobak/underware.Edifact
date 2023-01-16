using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class E984
    {
				[ElementInfo(0, "Charge unit, coded", "C", "", "an..3", "" )]
public string E5261 { get; set; }
		[ElementInfo(1, "Monetary amount value", "C", "", "n..35", "" )]
public string E5004 { get; set; }
		[ElementInfo(2, "Item description", "C", "", "an..256", "" )]
public string E7008 { get; set; }
		[ElementInfo(3, "Quantity", "C", "", "an..35", "" )]
public string E6060 { get; set; }
		[ElementInfo(4, "Charge period type, coded", "C", "", "an..3", "" )]
public string E2155 { get; set; }
		[ElementInfo(5, "Currency identification code", "C", "", "an..3", "" )]
public string E6345 { get; set; }
		[ElementInfo(6, "Location name code", "C", "", "an..25", "" )]
public string E3225 { get; set; }
		[ElementInfo(7, "Free text value", "C", "", "an..512", "" )]
public string E4440 { get; set; }
		[ElementInfo(8, "Maintenance operation, coded", "C", "", "an..3", "" )]
public string E4513 { get; set; }
		[ElementInfo(9, "Requirement designator, coded", "C", "", "an..3", "" )]
public string E7299 { get; set; }

    }
}