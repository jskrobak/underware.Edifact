using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D95A.Composites
{
    public class C786
    {
				[ElementInfo(0, "Structure component identifier", "M", "", "an..35", "" )]
public string E7512 { get; set; }
		[ElementInfo(1, "Identity number qualifier", "C", "", "an..3", "" )]
public string E7405 { get; set; }

    }
}