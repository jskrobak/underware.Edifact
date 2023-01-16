using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class E022
    {
				[ElementInfo(0, "Instruction description code", "M", "", "an..3", "" )]
public string E4401 { get; set; }
		[ElementInfo(1, "Instruction type code qualifier", "C", "", "an..3", "" )]
public string E4403 { get; set; }

    }
}