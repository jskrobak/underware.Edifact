using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04B.Composites
{
    public class C849
    {
				[ElementInfo(0, "Enacting party identifier", "M", "", "an..35", "" )]
public string E3301 { get; set; }
		[ElementInfo(1, "Instruction receiving party identifier", "C", "", "an..35", "" )]
public string E3285 { get; set; }

    }
}