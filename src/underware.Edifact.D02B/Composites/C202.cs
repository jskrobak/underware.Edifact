using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02B.Composites
{
    public class C202
    {
				[ElementInfo(0, "Package type description code", "C", "", "an..17", "" )]
public string E7065 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Type of packages", "C", "", "an..35", "" )]
public string E7064 { get; set; }

    }
}