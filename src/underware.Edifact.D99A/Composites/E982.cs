using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class E982
    {
				[ElementInfo(0, "Rate type identification", "C", "", "an..20", "" )]
public string E5263 { get; set; }
		[ElementInfo(1, "Monetary amount", "C", "", "n..35", "" )]
public string E5004 { get; set; }
		[ElementInfo(2, "Currency, coded", "C", "", "an..3", "" )]
public string E6345 { get; set; }
		[ElementInfo(3, "Rate plan, coded", "C", "", "an..3", "" )]
public string E5501 { get; set; }
		[ElementInfo(4, "Monetary amount type qualifier", "C", "", "an..3", "" )]
public string E5025 { get; set; }
		[ElementInfo(5, "Number of periods", "C", "", "n..3", "" )]
public string E2152 { get; set; }
		[ElementInfo(6, "Price change indicator, coded", "C", "", "an..3", "" )]
public string E5377 { get; set; }
		[ElementInfo(7, "Total monetary amount", "C", "", "n..20", "" )]
public string E5160 { get; set; }
		[ElementInfo(8, "Date", "C", "", "an..14", "" )]
public string E2000 { get; set; }
		[ElementInfo(9, "Date", "C", "", "an..14", "" )]
public string E2000_0 { get; set; }
		[ElementInfo(10, "Special conditions, coded", "C", "", "an..3", "" )]
public string E4183 { get; set; }

    }
}