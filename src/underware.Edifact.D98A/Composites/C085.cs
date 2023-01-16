using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98A.Composites
{
    public class C085
    {
				[ElementInfo(0, "Marital status, coded", "C", "", "an..3", "" )]
public string E3479 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Marital status", "C", "", "an..35", "" )]
public string E3478 { get; set; }

    }
}