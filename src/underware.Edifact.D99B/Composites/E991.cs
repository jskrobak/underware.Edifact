using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class E991
    {
				[ElementInfo(0, "Equipment size and type description", "C", "", "an..35", "" )]
public string E8154 { get; set; }
		[ElementInfo(1, "Object identifier", "C", "", "an..35", "" )]
public string E7402 { get; set; }

    }
}