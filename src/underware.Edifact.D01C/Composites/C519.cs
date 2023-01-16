using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01C.Composites
{
    public class C519
    {
				[ElementInfo(0, "First related location name code", "C", "", "an..25", "" )]
public string E3223 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "First related location name", "C", "", "an..70", "" )]
public string E3222 { get; set; }

    }
}