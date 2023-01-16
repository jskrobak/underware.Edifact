using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03A.Composites
{
    public class C970
    {
				[ElementInfo(0, "Clause name code", "C", "", "an..17", "" )]
public string E4069 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Clause name", "C", "", "an..70", "" )]
public string E4068 { get; set; }

    }
}