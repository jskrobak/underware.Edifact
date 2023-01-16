using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D95B.Composites
{
    public class C235
    {
				[ElementInfo(0, "Hazard identification number, upper part", "C", "", "an..4", "" )]
public string E8158 { get; set; }
		[ElementInfo(1, "Substance identification number, lower part", "C", "", "an4", "" )]
public string E8186 { get; set; }

    }
}