using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03B.Composites
{
    public class C878
    {
				[ElementInfo(0, "Institution branch identifier", "M", "", "an..17", "" )]
public string E3434 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Account holder identifier", "C", "", "an..35", "" )]
public string E3194 { get; set; }
		[ElementInfo(4, "Currency identification code", "C", "", "an..3", "" )]
public string E6345 { get; set; }

    }
}