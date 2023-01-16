using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class C186
    {
				[ElementInfo(0, "Quantity type code qualifier", "M", "", "an..3", "" )]
public string E6063 { get; set; }
		[ElementInfo(1, "Quantity", "M", "", "an..35", "" )]
public string E6060 { get; set; }
		[ElementInfo(2, "Measurement unit code", "C", "", "an..3", "" )]
public string E6411 { get; set; }

    }
}