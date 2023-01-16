using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02B.Composites
{
    public class E025
    {
				[ElementInfo(0, "Service basis code qualifier", "M", "", "an..3", "" )]
public string E9641 { get; set; }
		[ElementInfo(1, "Product identifier", "M", "", "an..35", "" )]
public string E7135 { get; set; }
		[ElementInfo(2, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(3, "Date or time or period text", "C", "", "an..35", "" )]
public string E2380 { get; set; }
		[ElementInfo(4, "Date or time or period format code", "C", "", "an..3", "" )]
public string E2379 { get; set; }
		[ElementInfo(5, "Monetary amount", "C", "", "n..35", "" )]
public string E5004 { get; set; }

    }
}