using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class C516
    {
				[ElementInfo(0, "Monetary amount type qualifier", "M", "", "an..3", "" )]
public string E5025 { get; set; }
		[ElementInfo(1, "Monetary amount", "C", "", "n..35", "" )]
public string E5004 { get; set; }
		[ElementInfo(2, "Currency, coded", "C", "", "an..3", "" )]
public string E6345 { get; set; }
		[ElementInfo(3, "Currency qualifier", "C", "", "an..3", "" )]
public string E6343 { get; set; }
		[ElementInfo(4, "Status, coded", "C", "", "an..3", "" )]
public string E4405 { get; set; }

    }
}