using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03A.Composites
{
    public class E973
    {
				[ElementInfo(0, "Party name", "C", "", "an..35", "" )]
public string E3036 { get; set; }
		[ElementInfo(1, "Location name code", "C", "", "an..35", "" )]
public string E3225 { get; set; }
		[ElementInfo(2, "Location name", "C", "", "an..256", "" )]
public string E3224 { get; set; }

    }
}