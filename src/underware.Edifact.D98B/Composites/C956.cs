using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class C956
    {
				[ElementInfo(0, "Attribute, coded", "C", "", "an..3", "" )]
public string E9019 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Attribute", "C", "", "an..35", "" )]
public string E9018 { get; set; }

    }
}