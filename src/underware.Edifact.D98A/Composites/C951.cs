using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98A.Composites
{
    public class C951
    {
				[ElementInfo(0, "Occupation, coded", "C", "", "an..3", "" )]
public string E9009 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Occupation", "C", "", "an..35", "" )]
public string E9008 { get; set; }
		[ElementInfo(4, "Occupation", "C", "", "an..35", "" )]
public string E9008_0 { get; set; }

    }
}