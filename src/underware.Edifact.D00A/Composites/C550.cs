
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00A.Composites
{
    public class C550
    {
				[ElementInfo(0, "Requirement or condition description identifier", "M", "", "an..17", "" )]
public string E7295 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Requirement or condition description", "C", "", "an..35", "" )]
public string E7294 { get; set; }

    }
}