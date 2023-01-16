using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C849
    {
				[ElementInfo(0, "Enacting party identifier", "Mandatory", "", "", "" )]
public string E3301 { get; set; }
		[ElementInfo(1, "Instruction receiving party identifier", "Conditional", "", "", "" )]
public string E3285 { get; set; }

    }
}