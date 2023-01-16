using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D96A.Composites
{
    public class C532
    {
				[ElementInfo(0, "Returnable package freight payment responsibility, coded", "C", "", "an..3", "" )]
public string E8395 { get; set; }
		[ElementInfo(1, "Returnable package load contents, coded", "C", "", "an..3", "" )]
public string E8393 { get; set; }

    }
}