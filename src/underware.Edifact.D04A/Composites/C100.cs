using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04A.Composites
{
    public class C100
    {
				[ElementInfo(0, "Delivery or transport terms description code", "C", "", "an..3", "" )]
public string E4053 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Delivery or transport terms description", "C", "", "an..70", "" )]
public string E4052 { get; set; }
		[ElementInfo(4, "Delivery or transport terms description", "C", "", "an..70", "" )]
public string E4052_0 { get; set; }

    }
}