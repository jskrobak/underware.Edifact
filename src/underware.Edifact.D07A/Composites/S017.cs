using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class S017
    {
				[ElementInfo(0, "Message implementation guideline identification", "Mandatory", "", "", "" )]
public string E0121 { get; set; }
		[ElementInfo(1, "Message implementation guideline version number", "Conditional", "", "", "" )]
public string E0122 { get; set; }
		[ElementInfo(2, "Message implementation guideline release number", "Conditional", "", "", "" )]
public string E0124 { get; set; }
		[ElementInfo(3, "Controlling agency, coded", "Conditional", "", "", "" )]
public string E0051 { get; set; }

    }
}