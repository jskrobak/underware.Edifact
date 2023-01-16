using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C206
    {
				[ElementInfo(0, "Object identifier", "Mandatory", "", "", "" )]
public string E7402 { get; set; }
		[ElementInfo(1, "Object identification code qualifier", "Conditional", "", "", "" )]
public string E7405 { get; set; }
		[ElementInfo(2, "Status description code", "Conditional", "", "", "" )]
public string E4405 { get; set; }

    }
}