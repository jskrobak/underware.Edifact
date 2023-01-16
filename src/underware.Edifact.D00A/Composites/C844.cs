
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00A.Composites
{
    public class C844
    {
				[ElementInfo(0, "Organisational class name code", "C", "", "an..17", "" )]
public string E3083 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Organisational class name", "C", "", "an..70", "" )]
public string E3082 { get; set; }

    }
}