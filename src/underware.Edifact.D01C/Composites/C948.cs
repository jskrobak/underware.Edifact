using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01C.Composites
{
    public class C948
    {
				[ElementInfo(0, "Employment category description code", "C", "", "an..3", "" )]
public string E9005 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Employment category description", "C", "", "an..35", "" )]
public string E9004 { get; set; }

    }
}