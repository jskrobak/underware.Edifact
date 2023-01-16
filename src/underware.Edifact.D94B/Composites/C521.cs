using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D94B.Composites
{
    public class C521
    {
				[ElementInfo(0, "Business function qualifier", "M", "", "an..3", "" )]
public string E4027 { get; set; }
		[ElementInfo(1, "Business function, coded", "M", "", "an..3", "" )]
public string E4025 { get; set; }
		[ElementInfo(2, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(3, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(4, "Business description", "C", "", "an..70", "" )]
public string E4022 { get; set; }

    }
}