using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class S009
    {
				[ElementInfo(0, "Message type", "Mandatory", "", "", "" )]
public string E0065 { get; set; }
		[ElementInfo(1, "Message version number", "Mandatory", "", "", "" )]
public string E0052 { get; set; }
		[ElementInfo(2, "Message release number", "Mandatory", "", "", "" )]
public string E0054 { get; set; }
		[ElementInfo(3, "Controlling agency, coded", "Mandatory", "", "", "" )]
public string E0051 { get; set; }
		[ElementInfo(4, "Association assigned code", "Conditional", "", "", "" )]
public string E0057 { get; set; }
		[ElementInfo(5, "Code list directory version number", "Conditional", "", "", "" )]
public string E0110 { get; set; }
		[ElementInfo(6, "Message type sub-function identification", "Conditional", "", "", "" )]
public string E0113 { get; set; }

    }
}