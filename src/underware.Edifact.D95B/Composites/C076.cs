using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D95B.Composites
{
    public class C076
    {
				[ElementInfo(0, "Communication number", "M", "", "an..25", "" )]
public string E3148 { get; set; }
		[ElementInfo(1, "Communication channel qualifier", "M", "", "an..3", "" )]
public string E3155 { get; set; }

    }
}