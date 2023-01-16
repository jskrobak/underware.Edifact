using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class C545
    {
				[ElementInfo(0, "Index qualifier", "M", "", "an..3", "" )]
public string E5013 { get; set; }
		[ElementInfo(1, "Index type, coded", "C", "", "an..3", "" )]
public string E5027 { get; set; }
		[ElementInfo(2, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(3, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }

    }
}