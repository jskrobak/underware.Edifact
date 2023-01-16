using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class C228
    {
				[ElementInfo(0, "Type of means of transport identification", "C", "", "an..8", "" )]
public string E8179 { get; set; }
		[ElementInfo(1, "Type of means of transport", "C", "", "an..17", "" )]
public string E8178 { get; set; }

    }
}