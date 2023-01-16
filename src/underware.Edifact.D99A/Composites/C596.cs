using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class C596
    {
				[ElementInfo(0, "Type of accounting entry identification", "M", "", "an..17", "" )]
public string E4475 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Type of accounting entry", "C", "", "an..35", "" )]
public string E4474 { get; set; }

    }
}