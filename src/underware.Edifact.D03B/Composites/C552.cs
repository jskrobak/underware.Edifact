using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03B.Composites
{
    public class C552
    {
				[ElementInfo(0, "Allowance or charge identifier", "C", "", "an..35", "" )]
public string E1230 { get; set; }
		[ElementInfo(1, "Allowance or charge identification code", "C", "", "an..3", "" )]
public string E5189 { get; set; }

    }
}