using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03A.Composites
{
    public class C553
    {
				[ElementInfo(0, "Second related location name code", "C", "", "an..25", "" )]
public string E3233 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Second related location name", "C", "", "an..70", "" )]
public string E3232 { get; set; }

    }
}