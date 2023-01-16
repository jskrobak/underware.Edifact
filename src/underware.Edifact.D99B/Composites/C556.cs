using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class C556
    {
				[ElementInfo(0, "Status reason description code", "M", "", "an..3", "" )]
public string E9013 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Status reason description", "C", "", "an..256", "" )]
public string E9012 { get; set; }

    }
}