using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01C.Composites
{
    public class C941
    {
				[ElementInfo(0, "Relationship description code", "C", "", "an..3", "" )]
public string E9143 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Relationship description", "C", "", "an..35", "" )]
public string E9142 { get; set; }

    }
}