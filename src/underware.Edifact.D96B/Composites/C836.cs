using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D96B.Composites
{
    public class C836
    {
				[ElementInfo(0, "Clinical information identification", "C", "", "an..17", "" )]
public string E6413 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Clinical information", "C", "", "an..70", "" )]
public string E6412 { get; set; }

    }
}