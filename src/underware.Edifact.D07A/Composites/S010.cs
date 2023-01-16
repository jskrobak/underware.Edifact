using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class S010
    {
				[ElementInfo(0, "Sequence of transfers", "Mandatory", "", "", "" )]
public string E0070 { get; set; }
		[ElementInfo(1, "First and last transfer", "Conditional", "", "", "" )]
public string E0073 { get; set; }

    }
}