using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04B.Composites
{
    public class C889
    {
				[ElementInfo(0, "Characteristic value description code", "C", "", "an..3", "" )]
public string E7111 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Characteristic value description", "C", "", "an..35", "" )]
public string E7110 { get; set; }
		[ElementInfo(4, "Characteristic value description", "C", "", "an..35", "" )]
public string E7110_0 { get; set; }

    }
}