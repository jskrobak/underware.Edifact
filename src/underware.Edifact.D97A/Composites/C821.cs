using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D97A.Composites
{
    public class C821
    {
				[ElementInfo(0, "Type of damage, coded", "C", "", "an..3", "" )]
public string E7501 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Type of damage", "C", "", "an..35", "" )]
public string E7500 { get; set; }

    }
}