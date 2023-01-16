using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C106
    {
				[ElementInfo(0, "Document identifier", "Conditional", "", "", "" )]
public string E1004 { get; set; }
		[ElementInfo(1, "Version identifier", "Conditional", "", "", "" )]
public string E1056 { get; set; }
		[ElementInfo(2, "Revision identifier", "Conditional", "", "", "" )]
public string E1060 { get; set; }

    }
}