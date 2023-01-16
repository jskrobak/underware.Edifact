using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D95A.Composites
{
    public class C239
    {
				[ElementInfo(0, "Temperature setting", "C", "", "n3", "" )]
public string E6246 { get; set; }
		[ElementInfo(1, "Measure unit qualifier", "C", "", "an..3", "" )]
public string E6411 { get; set; }

    }
}