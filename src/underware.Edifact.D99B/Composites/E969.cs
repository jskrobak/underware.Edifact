using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class E969
    {
				[ElementInfo(0, "Date value", "M", "", "an..14", "" )]
public string E2000 { get; set; }
		[ElementInfo(1, "Date value", "C", "", "an..14", "" )]
public string E2000_0 { get; set; }

    }
}