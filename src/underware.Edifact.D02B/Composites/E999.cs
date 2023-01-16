using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02B.Composites
{
    public class E999
    {
				[ElementInfo(0, "Location name code", "C", "", "an..35", "" )]
public string E3225 { get; set; }
		[ElementInfo(1, "Party name", "C", "", "an..35", "" )]
public string E3036 { get; set; }
		[ElementInfo(2, "Time", "C", "", "n4", "" )]
public string E2002 { get; set; }
		[ElementInfo(3, "Time", "C", "", "n4", "" )]
public string E2002_0 { get; set; }
		[ElementInfo(4, "Location name", "C", "", "an..256", "" )]
public string E3224 { get; set; }
		[ElementInfo(5, "Location function code qualifier", "C", "", "an..3", "" )]
public string E3227 { get; set; }
		[ElementInfo(6, "Country name code", "C", "", "an..3", "" )]
public string E3207 { get; set; }
		[ElementInfo(7, "Sequence position identifier", "C", "", "an..10", "" )]
public string E1050 { get; set; }

    }
}