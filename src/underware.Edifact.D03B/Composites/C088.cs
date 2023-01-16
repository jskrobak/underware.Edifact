using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03B.Composites
{
    public class C088
    {
				[ElementInfo(0, "Institution name code", "C", "", "an..11", "" )]
public string E3433 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Institution branch identifier", "C", "", "an..17", "" )]
public string E3434 { get; set; }
		[ElementInfo(4, "Code list identification code", "C", "", "an..17", "" )]
public string E1131_0 { get; set; }
		[ElementInfo(5, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055_0 { get; set; }
		[ElementInfo(6, "Institution name", "C", "", "an..70", "" )]
public string E3432 { get; set; }
		[ElementInfo(7, "Institution branch location name", "C", "", "an..70", "" )]
public string E3436 { get; set; }

    }
}