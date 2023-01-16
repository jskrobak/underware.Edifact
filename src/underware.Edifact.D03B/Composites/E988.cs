using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03B.Composites
{
    public class E988
    {
				[ElementInfo(0, "Party name", "M", "", "an..35", "" )]
public string E3036 { get; set; }
		[ElementInfo(1, "Party name", "C", "", "an..35", "" )]
public string E3036_0 { get; set; }
		[ElementInfo(2, "Party name", "C", "", "an..35", "" )]
public string E3036_1 { get; set; }

    }
}