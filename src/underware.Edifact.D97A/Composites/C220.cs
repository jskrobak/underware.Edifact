using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D97A.Composites
{
    public class C220
    {
				[ElementInfo(0, "Mode of transport, coded", "C", "", "an..3", "" )]
public string E8067 { get; set; }
		[ElementInfo(1, "Mode of transport", "C", "", "an..17", "" )]
public string E8066 { get; set; }

    }
}