using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D97A.Composites
{
    public class E006
    {
				[ElementInfo(0, "Special conditions, coded", "M", "", "an..3", "" )]
public string E4183 { get; set; }
		[ElementInfo(1, "Status indicator, coded", "M", "", "an..3", "" )]
public string E1245 { get; set; }

    }
}