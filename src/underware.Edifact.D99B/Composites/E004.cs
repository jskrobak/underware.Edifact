using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class E004
    {
				[ElementInfo(0, "Special condition code", "M", "", "an..3", "" )]
public string E4183 { get; set; }
		[ElementInfo(1, "Number of units", "C", "", "n..15", "" )]
public string E6350 { get; set; }
		[ElementInfo(2, "Unit type code qualifier", "C", "", "an..3", "" )]
public string E6353 { get; set; }
		[ElementInfo(3, "Relation, coded", "C", "", "an..3", "" )]
public string E5479 { get; set; }
		[ElementInfo(4, "Days of operation", "C", "", "an..7", "" )]
public string E2160 { get; set; }
		[ElementInfo(5, "Monetary amount value", "C", "", "n..35", "" )]
public string E5004 { get; set; }
		[ElementInfo(6, "Monetary amount type code qualifier", "C", "", "an..3", "" )]
public string E5025 { get; set; }
		[ElementInfo(7, "Currency identification code", "C", "", "an..3", "" )]
public string E6345 { get; set; }
		[ElementInfo(8, "Free text value", "C", "", "an..512", "" )]
public string E4440 { get; set; }
		[ElementInfo(9, "Free text value", "C", "", "an..512", "" )]
public string E4440_0 { get; set; }
		[ElementInfo(10, "Free text value", "C", "", "an..512", "" )]
public string E4440_1 { get; set; }
		[ElementInfo(11, "Free text value", "C", "", "an..512", "" )]
public string E4440_2 { get; set; }
		[ElementInfo(12, "Free text value", "C", "", "an..512", "" )]
public string E4440_3 { get; set; }
		[ElementInfo(13, "Free text value", "C", "", "an..512", "" )]
public string E4440_4 { get; set; }
		[ElementInfo(14, "Free text value", "C", "", "an..512", "" )]
public string E4440_5 { get; set; }
		[ElementInfo(15, "Free text value", "C", "", "an..512", "" )]
public string E4440_6 { get; set; }
		[ElementInfo(16, "Free text value", "C", "", "an..512", "" )]
public string E4440_7 { get; set; }

    }
}