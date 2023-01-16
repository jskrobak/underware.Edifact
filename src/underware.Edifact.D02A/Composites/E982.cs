using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02A.Composites
{
    public class E982
    {
				[ElementInfo(0, "Rate type identifier", "C", "", "an..20", "" )]
public string E5263 { get; set; }
		[ElementInfo(1, "Monetary amount", "C", "", "n..35", "" )]
public string E5004 { get; set; }
		[ElementInfo(2, "Currency identification code", "C", "", "an..3", "" )]
public string E6345 { get; set; }
		[ElementInfo(3, "Rate plan code", "C", "", "an..3", "" )]
public string E5501 { get; set; }
		[ElementInfo(4, "Monetary amount type code qualifier", "C", "", "an..3", "" )]
public string E5025 { get; set; }
		[ElementInfo(5, "Period count quantity", "C", "", "n..3", "" )]
public string E2152 { get; set; }
		[ElementInfo(6, "Price change type code", "C", "", "an..3", "" )]
public string E5377 { get; set; }
		[ElementInfo(7, "Total monetary amount", "C", "", "n..20", "" )]
public string E5160 { get; set; }
		[ElementInfo(8, "Date", "C", "", "an..14", "" )]
public string E2000 { get; set; }
		[ElementInfo(9, "Date", "C", "", "an..14", "" )]
public string E2000_0 { get; set; }
		[ElementInfo(10, "Special condition code", "C", "", "an..3", "" )]
public string E4183 { get; set; }
		[ElementInfo(11, "Quantity", "C", "", "an..35", "" )]
public string E6060 { get; set; }
		[ElementInfo(12, "Status description code", "C", "", "an..3", "" )]
public string E4405 { get; set; }

    }
}