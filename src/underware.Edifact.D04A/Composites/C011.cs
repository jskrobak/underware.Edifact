using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04A.Composites
{
    public class C011
    {
				[ElementInfo(0, "Information detail description code", "C", "", "an..17", "" )]
public string E9617 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Information detail description", "C", "", "an..256", "" )]
public string E9616 { get; set; }

    }
}