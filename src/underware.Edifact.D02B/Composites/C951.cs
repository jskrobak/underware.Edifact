using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02B.Composites
{
    public class C951
    {
				[ElementInfo(0, "Occupation description code", "C", "", "an..3", "" )]
public string E9009 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Occupation description", "C", "", "an..35", "" )]
public string E9008 { get; set; }
		[ElementInfo(4, "Occupation description", "C", "", "an..35", "" )]
public string E9008_0 { get; set; }

    }
}