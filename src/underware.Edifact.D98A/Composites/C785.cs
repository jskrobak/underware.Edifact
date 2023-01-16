using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98A.Composites
{
    public class C785
    {
				[ElementInfo(0, "Statistical concept identifier", "M", "", "an..35", "" )]
public string E6434 { get; set; }
		[ElementInfo(1, "Identity number qualifier", "C", "", "an..3", "" )]
public string E7405 { get; set; }

    }
}