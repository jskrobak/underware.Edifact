using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C088
    {
				[ElementInfo(0, "Institution name code", "Conditional", "", "", "" )]
public string E3433 { get; set; }
		[ElementInfo(1, "Code list identification code", "Conditional", "", "", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "Conditional", "", "", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Institution branch identifier", "Conditional", "", "", "" )]
public string E3434 { get; set; }
		[ElementInfo(4, "Code list identification code", "Conditional", "", "", "" )]
public string E1131_0 { get; set; }
		[ElementInfo(5, "Code list responsible agency code", "Conditional", "", "", "" )]
public string E3055_0 { get; set; }
		[ElementInfo(6, "Institution name", "Conditional", "", "", "" )]
public string E3432 { get; set; }
		[ElementInfo(7, "Institution branch location name", "Conditional", "", "", "" )]
public string E3436 { get; set; }

    }
}