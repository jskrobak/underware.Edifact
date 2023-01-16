using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03A.Composites
{
    public class C819
    {
				[ElementInfo(0, "Country sub-entity name code", "C", "", "an..9", "" )]
public string E3229 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Country sub-entity name", "C", "", "an..70", "" )]
public string E3228 { get; set; }

    }
}