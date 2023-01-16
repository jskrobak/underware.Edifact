using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class E993
    {
				[ElementInfo(0, "Product identification", "C", "", "an..35", "" )]
public string E7135 { get; set; }
		[ElementInfo(1, "Party name", "C", "", "an..35", "" )]
public string E3036 { get; set; }
		[ElementInfo(2, "Length dimension", "C", "", "n..15", "" )]
public string E6168 { get; set; }
		[ElementInfo(3, "Number of stops", "C", "", "n..3", "" )]
public string E8216 { get; set; }
		[ElementInfo(4, "Days of operation", "C", "", "an..7", "" )]
public string E2160 { get; set; }
		[ElementInfo(5, "Number of units", "C", "", "n..15", "" )]
public string E6350 { get; set; }
		[ElementInfo(6, "Quantity", "C", "", "n..15", "" )]
public string E6060 { get; set; }

    }
}