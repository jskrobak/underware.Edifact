using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03A.Composites
{
    public class C080
    {
				[ElementInfo(0, "Party name", "M", "", "an..35", "" )]
public string E3036 { get; set; }
		[ElementInfo(1, "Party name", "C", "", "an..35", "" )]
public string E3036_0 { get; set; }
		[ElementInfo(2, "Party name", "C", "", "an..35", "" )]
public string E3036_1 { get; set; }
		[ElementInfo(3, "Party name", "C", "", "an..35", "" )]
public string E3036_2 { get; set; }
		[ElementInfo(4, "Party name", "C", "", "an..35", "" )]
public string E3036_3 { get; set; }
		[ElementInfo(5, "Party name format code", "C", "", "an..3", "" )]
public string E3045 { get; set; }

    }
}