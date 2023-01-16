using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class E025
    {
				[ElementInfo(0, "Basis of service code qualifier", "M", "", "an..3", "" )]
public string E9641 { get; set; }
		[ElementInfo(1, "Product identifier", "M", "", "an..35", "" )]
public string E7135 { get; set; }
		[ElementInfo(2, "Code list identification code", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(3, "Date/time/period value", "C", "", "an..35", "" )]
public string E2380 { get; set; }
		[ElementInfo(4, "Date/time/period format code", "C", "", "an..3", "" )]
public string E2379 { get; set; }
		[ElementInfo(5, "Monetary amount value", "C", "", "n..35", "" )]
public string E5004 { get; set; }

    }
}