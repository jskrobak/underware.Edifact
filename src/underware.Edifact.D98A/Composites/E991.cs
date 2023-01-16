using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98A.Composites
{
    public class E991
    {
				[ElementInfo(0, "Equipment size and type", "C", "", "an..35", "" )]
public string E8154 { get; set; }
		[ElementInfo(1, "Identity number", "C", "", "an..35", "" )]
public string E7402 { get; set; }

    }
}