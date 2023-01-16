using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D94B.Composites
{
    public class C941
    {
				[ElementInfo(0, "Relationship, coded", "C", "", "an..3", "" )]
public string E9143 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Relationship", "C", "", "an..35", "" )]
public string E9142 { get; set; }

    }
}