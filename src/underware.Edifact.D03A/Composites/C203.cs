using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03A.Composites
{
    public class C203
    {
				[ElementInfo(0, "Rate or tariff class description code", "M", "", "an..9", "" )]
public string E5243 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Rate or tariff class description", "C", "", "an..35", "" )]
public string E5242 { get; set; }
		[ElementInfo(4, "Supplementary rate or tariff code", "C", "", "an..6", "" )]
public string E5275 { get; set; }
		[ElementInfo(5, "Code list identification code", "C", "", "an..17", "" )]
public string E1131_0 { get; set; }
		[ElementInfo(6, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055_0 { get; set; }
		[ElementInfo(7, "Supplementary rate or tariff code", "C", "", "an..6", "" )]
public string E5275_0 { get; set; }
		[ElementInfo(8, "Code list identification code", "C", "", "an..17", "" )]
public string E1131_1 { get; set; }
		[ElementInfo(9, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055_1 { get; set; }

    }
}