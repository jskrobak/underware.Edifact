using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C850
    {
				[ElementInfo(0, "Status description code", "Mandatory", "", "", "" )]
public string E4405 { get; set; }
		[ElementInfo(1, "Party name", "Conditional", "", "", "" )]
public string E3036 { get; set; }

    }
}