using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D93A.Composites
{
    public class C138
    {
				[ElementInfo(0, "Price multiplier", "M", "", "n..12", "" )]
public string E5394 { get; set; }
		[ElementInfo(1, "Price multiplier qualifier", "C", "", "an..3", "" )]
public string E5393 { get; set; }

    }
}