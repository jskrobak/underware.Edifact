
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00A.Composites
{
    public class C564
    {
				[ElementInfo(0, "Physical or logical state description code", "C", "", "an..3", "" )]
public string E7007 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Physical or logical state description", "C", "", "an..70", "" )]
public string E7006 { get; set; }

    }
}