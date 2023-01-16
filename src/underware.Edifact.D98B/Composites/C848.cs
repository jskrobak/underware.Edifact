using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class C848
    {
				[ElementInfo(0, "Measurement unit identification", "C", "", "an..8", "" )]
public string E6417 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Measurement unit", "C", "", "an..35", "" )]
public string E6416 { get; set; }

    }
}