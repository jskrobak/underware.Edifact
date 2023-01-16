using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04A.Composites
{
    public class C836
    {
				[ElementInfo(0, "Clinical information description identifier", "C", "", "an..17", "" )]
public string E6413 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Clinical information description", "C", "", "an..70", "" )]
public string E6412 { get; set; }

    }
}