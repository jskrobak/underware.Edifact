using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04B.Composites
{
    public class C956
    {
				[ElementInfo(0, "Attribute description code", "C", "", "an..17", "" )]
public string E9019 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Attribute description", "C", "", "an..256", "" )]
public string E9018 { get; set; }

    }
}