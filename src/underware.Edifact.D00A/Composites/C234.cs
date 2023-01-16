
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00A.Composites
{
    public class C234
    {
				[ElementInfo(0, "United Nations Dangerous Goods identification code", "C", "", "n4", "" )]
public string E7124 { get; set; }
		[ElementInfo(1, "Dangerous goods flashpoint value", "C", "", "an..8", "" )]
public string E7088 { get; set; }

    }
}