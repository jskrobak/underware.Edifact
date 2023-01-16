using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class E012
    {
				[ElementInfo(0, "Party qualifier", "M", "", "an..3", "" )]
public string E3035 { get; set; }
		[ElementInfo(1, "Party name", "C", "", "an..35", "" )]
public string E3036 { get; set; }
		[ElementInfo(2, "Party identification", "C", "", "an..35", "" )]
public string E3039 { get; set; }
		[ElementInfo(3, "Name status, coded", "C", "", "an..3", "" )]
public string E3397 { get; set; }

    }
}