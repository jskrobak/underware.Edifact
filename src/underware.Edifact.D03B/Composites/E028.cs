using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03B.Composites
{
    public class E028
    {
				[ElementInfo(0, "Related cause code", "C", "", "an..3", "" )]
public string E9625 { get; set; }
		[ElementInfo(1, "Date", "C", "", "an..14", "" )]
public string E2000 { get; set; }
		[ElementInfo(2, "Country sub-entity name code", "C", "", "an..9", "" )]
public string E3229 { get; set; }

    }
}