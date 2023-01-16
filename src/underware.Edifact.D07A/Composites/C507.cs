using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C507
    {
				[ElementInfo(0, "Date or time or period function code qualifier", "Mandatory", "", "", "" )]
public string E2005 { get; set; }
		[ElementInfo(1, "Date or time or period text", "Conditional", "", "", "" )]
public string E2380 { get; set; }
		[ElementInfo(2, "Date or time or period format code", "Conditional", "", "", "" )]
public string E2379 { get; set; }

    }
}