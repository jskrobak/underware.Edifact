using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D94A.Composites
{
    public class C270
    {
				[ElementInfo(0, "Control qualifier", "M", "", "an..3", "" )]
public string E6069 { get; set; }
		[ElementInfo(1, "Control value", "M", "", "n..18", "" )]
public string E6066 { get; set; }
		[ElementInfo(2, "Measure unit qualifier", "C", "", "an..3", "" )]
public string E6411 { get; set; }

    }
}