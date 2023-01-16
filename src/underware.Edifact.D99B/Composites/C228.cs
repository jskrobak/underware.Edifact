using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class C228
    {
				[ElementInfo(0, "Transport means description code", "C", "", "an..8", "" )]
public string E8179 { get; set; }
		[ElementInfo(1, "Transport means description", "C", "", "an..17", "" )]
public string E8178 { get; set; }

    }
}