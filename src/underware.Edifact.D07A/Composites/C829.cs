using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C829
    {
				[ElementInfo(0, "Sub-line indicator code", "Conditional", "", "", "" )]
public string E5495 { get; set; }
		[ElementInfo(1, "Line item identifier", "Conditional", "", "", "" )]
public string E1082 { get; set; }

    }
}