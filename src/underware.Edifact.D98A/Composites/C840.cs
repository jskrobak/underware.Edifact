using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98A.Composites
{
    public class C840
    {
				[ElementInfo(0, "Admission type, coded", "C", "", "an..3", "" )]
public string E9445 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Admission type", "C", "", "an..35", "" )]
public string E9444 { get; set; }

    }
}