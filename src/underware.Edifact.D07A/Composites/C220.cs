using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C220
    {
				[ElementInfo(0, "Transport mode name code", "Conditional", "", "", "" )]
public string E8067 { get; set; }
		[ElementInfo(1, "Transport mode name", "Conditional", "", "", "" )]
public string E8066 { get; set; }

    }
}