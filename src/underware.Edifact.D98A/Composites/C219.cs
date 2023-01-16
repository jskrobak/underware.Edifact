using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98A.Composites
{
    public class C219
    {
				[ElementInfo(0, "Movement type, coded", "C", "", "an..3", "" )]
public string E8335 { get; set; }
		[ElementInfo(1, "Movement type", "C", "", "an..35", "" )]
public string E8334 { get; set; }

    }
}