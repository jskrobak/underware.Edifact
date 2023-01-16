using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D97B.Composites
{
    public class C525
    {
				[ElementInfo(0, "Purpose of conveyance call, coded", "C", "", "an..3", "" )]
public string E8025 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Purpose of conveyance call", "C", "", "an..35", "" )]
public string E8024 { get; set; }

    }
}