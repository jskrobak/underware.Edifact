using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D95B.Composites
{
    public class C824
    {
				[ElementInfo(0, "Component material, coded", "C", "", "an..3", "" )]
public string E7507 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Component material", "C", "", "an..35", "" )]
public string E7506 { get; set; }

    }
}