using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02B.Composites
{
    public class E946
    {
				[ElementInfo(0, "Certainty description code", "C", "", "an..3", "" )]
public string E4049 { get; set; }
		[ElementInfo(1, "Certainty description", "C", "", "an..35", "" )]
public string E4048 { get; set; }
		[ElementInfo(2, "Language name code", "C", "", "an..3", "" )]
public string E3453 { get; set; }
		[ElementInfo(3, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }

    }
}