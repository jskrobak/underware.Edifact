using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C202
    {
				[ElementInfo(0, "Package type description code", "Conditional", "", "", "" )]
public string E7065 { get; set; }
		[ElementInfo(1, "Code list identification code", "Conditional", "", "", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "Conditional", "", "", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Type of packages", "Conditional", "", "", "" )]
public string E7064 { get; set; }

    }
}