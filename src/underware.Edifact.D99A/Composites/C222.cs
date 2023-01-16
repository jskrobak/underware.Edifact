using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class C222
    {
				[ElementInfo(0, "Id. of means of transport identification", "C", "", "an..9", "" )]
public string E8213 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Id. of the means of transport", "C", "", "an..35", "" )]
public string E8212 { get; set; }
		[ElementInfo(4, "Nationality of means of transport, coded", "C", "", "an..3", "" )]
public string E8453 { get; set; }

    }
}