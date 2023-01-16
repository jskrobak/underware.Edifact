using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class S018
    {
				[ElementInfo(0, "Scenario identification", "Mandatory", "", "", "" )]
public string E0127 { get; set; }
		[ElementInfo(1, "Scenario version number", "Conditional", "", "", "" )]
public string E0128 { get; set; }
		[ElementInfo(2, "Scenario release number", "Conditional", "", "", "" )]
public string E0130 { get; set; }
		[ElementInfo(3, "Controlling agency, coded", "Conditional", "", "", "" )]
public string E0051 { get; set; }

    }
}