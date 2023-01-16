using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D96B.Composites
{
    public class C543
    {
				[ElementInfo(0, "Agreement type qualifier", "M", "", "an..3", "" )]
public string E7431 { get; set; }
		[ElementInfo(1, "Agreement type, coded", "C", "", "an..3", "" )]
public string E7433 { get; set; }
		[ElementInfo(2, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(3, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(4, "Agreement type description", "C", "", "an..70", "" )]
public string E7434 { get; set; }

    }
}