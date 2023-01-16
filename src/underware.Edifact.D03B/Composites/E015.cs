using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03B.Composites
{
    public class E015
    {
				[ElementInfo(0, "Item description code", "C", "", "an..17", "" )]
public string E7009 { get; set; }
		[ElementInfo(1, "Item description", "C", "", "an..256", "" )]
public string E7008 { get; set; }
		[ElementInfo(2, "Quantity", "C", "", "an..35", "" )]
public string E6060 { get; set; }
		[ElementInfo(3, "Monetary amount", "C", "", "n..35", "" )]
public string E5004 { get; set; }
		[ElementInfo(4, "Charge period type code", "C", "", "an..3", "" )]
public string E2155 { get; set; }
		[ElementInfo(5, "Charge unit code", "C", "", "an..3", "" )]
public string E5261 { get; set; }
		[ElementInfo(6, "Currency identification code", "C", "", "an..3", "" )]
public string E6345 { get; set; }
		[ElementInfo(7, "Information type code", "C", "", "an..4", "" )]
public string E4473 { get; set; }
		[ElementInfo(8, "Free text", "C", "", "an..512", "" )]
public string E4440 { get; set; }

    }
}