using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C235
    {
				[ElementInfo(0, "Orange hazard placard upper part identifier", "Conditional", "", "", "" )]
public string E8158 { get; set; }
		[ElementInfo(1, "Orange hazard placard lower part identifier", "Conditional", "", "", "" )]
public string E8186 { get; set; }

    }
}