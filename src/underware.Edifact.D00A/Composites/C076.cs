
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00A.Composites
{
    public class C076
    {
				[ElementInfo(0, "Communication number", "M", "", "an..512", "" )]
public string E3148 { get; set; }
		[ElementInfo(1, "Communication number code qualifier", "M", "", "an..3", "" )]
public string E3155 { get; set; }

    }
}