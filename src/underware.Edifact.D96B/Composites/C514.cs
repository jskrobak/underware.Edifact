using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D96B.Composites
{
    public class C514
    {
				[ElementInfo(0, "Sample location, coded", "C", "", "an..3", "" )]
public string E3237 { get; set; }
		[ElementInfo(1, "Sample location", "C", "", "an..35", "" )]
public string E3236 { get; set; }

    }
}