using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C208
    {
				[ElementInfo(0, "Object identifier", "Mandatory", "", "", "" )]
public string E7402 { get; set; }
		[ElementInfo(1, "Object identifier", "Conditional", "", "", "" )]
public string E7402_0 { get; set; }

    }
}