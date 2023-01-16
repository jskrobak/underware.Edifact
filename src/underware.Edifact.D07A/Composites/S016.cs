using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class S016
    {
				[ElementInfo(0, "Message subset identification", "Mandatory", "", "", "" )]
public string E0115 { get; set; }
		[ElementInfo(1, "Message subset version number", "Conditional", "", "", "" )]
public string E0116 { get; set; }
		[ElementInfo(2, "Message subset release number", "Conditional", "", "", "" )]
public string E0118 { get; set; }
		[ElementInfo(3, "Controlling agency, coded", "Conditional", "", "", "" )]
public string E0051 { get; set; }

    }
}