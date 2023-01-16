using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02A.Composites
{
    public class E975
    {
				[ElementInfo(0, "Location name code", "C", "", "an..35", "" )]
public string E3225 { get; set; }
		[ElementInfo(1, "Location name", "C", "", "an..256", "" )]
public string E3224 { get; set; }
		[ElementInfo(2, "Country name code", "C", "", "an..3", "" )]
public string E3207 { get; set; }
		[ElementInfo(3, "Location function code qualifier", "C", "", "an..3", "" )]
public string E3227 { get; set; }

    }
}