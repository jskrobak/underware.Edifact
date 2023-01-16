using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D97A.Composites
{
    public class E973
    {
				[ElementInfo(0, "Party name", "C", "", "an..35", "" )]
public string E3036 { get; set; }
		[ElementInfo(1, "Place/location identification", "C", "", "an..25", "" )]
public string E3225 { get; set; }
		[ElementInfo(2, "Place/location", "C", "", "an..70", "" )]
public string E3224 { get; set; }

    }
}