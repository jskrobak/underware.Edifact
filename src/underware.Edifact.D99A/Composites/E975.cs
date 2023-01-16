using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class E975
    {
				[ElementInfo(0, "Place/location identification", "C", "", "an..25", "" )]
public string E3225 { get; set; }
		[ElementInfo(1, "Place/location", "C", "", "an..70", "" )]
public string E3224 { get; set; }
		[ElementInfo(2, "Country, coded", "C", "", "an..3", "" )]
public string E3207 { get; set; }
		[ElementInfo(3, "Place/location qualifier", "C", "", "an..3", "" )]
public string E3227 { get; set; }

    }
}