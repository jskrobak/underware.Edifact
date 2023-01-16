using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D93A.Composites
{
    public class C262
    {
				[ElementInfo(0, "Change reason, coded", "C", "", "an..3", "" )]
public string E4295 { get; set; }
		[ElementInfo(1, "Change reason", "C", "", "an..35", "" )]
public string E4294 { get; set; }

    }
}