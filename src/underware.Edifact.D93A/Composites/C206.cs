using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D93A.Composites
{
    public class C206
    {
				[ElementInfo(0, "Identity number", "M", "", "an..35", "" )]
public string E7402 { get; set; }
		[ElementInfo(1, "Identity number qualifier", "C", "", "an..3", "" )]
public string E7405 { get; set; }

    }
}