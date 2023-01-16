using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01C.Composites
{
    public class C515
    {
				[ElementInfo(0, "Test reason name code", "C", "", "an..17", "" )]
public string E4425 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Test reason name", "C", "", "an..35", "" )]
public string E4424 { get; set; }

    }
}