using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D97A.Composites
{
    public class C206
    {
				[ElementInfo(0, "Identity number", "M", "", "an..35", "" )]
public string E7402 { get; set; }
		[ElementInfo(1, "Identity number qualifier", "C", "", "an..3", "" )]
public string E7405 { get; set; }
		[ElementInfo(2, "Status, coded", "C", "", "an..3", "" )]
public string E4405 { get; set; }

    }
}