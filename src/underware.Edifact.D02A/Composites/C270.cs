using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02A.Composites
{
    public class C270
    {
				[ElementInfo(0, "Control total type code qualifier", "M", "", "an..3", "" )]
public string E6069 { get; set; }
		[ElementInfo(1, "Control total quantity", "M", "", "n..18", "" )]
public string E6066 { get; set; }
		[ElementInfo(2, "Measurement unit code", "C", "", "an..3", "" )]
public string E6411 { get; set; }

    }
}