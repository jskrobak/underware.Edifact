using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class E974
    {
				[ElementInfo(0, "Agent identification", "C", "", "an..9", "" )]
public string E3197 { get; set; }
		[ElementInfo(1, "In-house identification", "C", "", "an..9", "" )]
public string E3465 { get; set; }
		[ElementInfo(2, "Agent identification", "C", "", "an..9", "" )]
public string E3197_0 { get; set; }
		[ElementInfo(3, "Party name", "C", "", "an..35", "" )]
public string E3036 { get; set; }

    }
}