using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03A.Composites
{
    public class E083
    {
				[ElementInfo(0, "Quantity type code qualifier", "M", "", "an..3", "" )]
public string E6063 { get; set; }
		[ElementInfo(1, "Quantity", "C", "", "an..35", "" )]
public string E6060 { get; set; }
		[ElementInfo(2, "Measurement unit code", "C", "", "an..8", "" )]
public string E6411 { get; set; }
		[ElementInfo(3, "Quantity", "C", "", "an..35", "" )]
public string E6060_0 { get; set; }
		[ElementInfo(4, "Period type code", "C", "", "an..3", "" )]
public string E2151 { get; set; }
		[ElementInfo(5, "Period count quantity", "C", "", "n..3", "" )]
public string E2152 { get; set; }
		[ElementInfo(6, "Despatch pattern code", "C", "", "an..3", "" )]
public string E2015 { get; set; }
		[ElementInfo(7, "Despatch pattern timing code", "C", "", "an..3", "" )]
public string E2017 { get; set; }

    }
}