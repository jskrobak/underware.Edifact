using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D96B.Composites
{
    public class C552
    {
				[ElementInfo(0, "Allowance or charge number", "C", "", "an..35", "" )]
public string E1230 { get; set; }
		[ElementInfo(1, "Charge/allowance description, coded", "C", "", "an..3", "" )]
public string E5189 { get; set; }

    }
}