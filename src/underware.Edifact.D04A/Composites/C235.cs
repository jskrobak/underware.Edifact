using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04A.Composites
{
    public class C235
    {
				[ElementInfo(0, "Orange hazard placard upper part identifier", "C", "", "an..4", "" )]
public string E8158 { get; set; }
		[ElementInfo(1, "Orange hazard placard lower part identifier", "C", "", "an4", "" )]
public string E8186 { get; set; }

    }
}