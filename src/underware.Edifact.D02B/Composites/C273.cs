using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02B.Composites
{
    public class C273
    {
				[ElementInfo(0, "Item description code", "C", "", "an..17", "" )]
public string E7009 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Item description", "C", "", "an..256", "" )]
public string E7008 { get; set; }
		[ElementInfo(4, "Item description", "C", "", "an..256", "" )]
public string E7008_0 { get; set; }
		[ElementInfo(5, "Language name code", "C", "", "an..3", "" )]
public string E3453 { get; set; }

    }
}