using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C205
    {
				[ElementInfo(0, "Hazard identification code", "Mandatory", "", "", "" )]
public string E8351 { get; set; }
		[ElementInfo(1, "Additional hazard classification identifier", "Conditional", "", "", "" )]
public string E8078 { get; set; }
		[ElementInfo(2, "Hazard code version identifier", "Conditional", "", "", "" )]
public string E8092 { get; set; }

    }
}