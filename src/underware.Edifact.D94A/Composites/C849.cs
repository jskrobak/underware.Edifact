using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D94A.Composites
{
    public class C849
    {
				[ElementInfo(0, "Party enacting instruction identification", "M", "", "an..17", "" )]
public string E3301 { get; set; }
		[ElementInfo(1, "Recipient of the instruction identification", "C", "", "an..17", "" )]
public string E3285 { get; set; }

    }
}