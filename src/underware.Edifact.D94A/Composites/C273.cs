using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D94A.Composites
{
    public class C273
    {
				[ElementInfo(0, "Item description identification", "C", "", "an..7", "" )]
public string E7009 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Item description", "C", "", "an..35", "" )]
public string E7008 { get; set; }
		[ElementInfo(4, "Item description", "C", "", "an..35", "" )]
public string E7008_0 { get; set; }

    }
}