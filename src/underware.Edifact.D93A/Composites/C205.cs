using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D93A.Composites
{
    public class C205
    {
				[ElementInfo(0, "Hazard code identification", "M", "", "an..7", "" )]
public string E8351 { get; set; }
		[ElementInfo(1, "Hazard substance/item/page number", "C", "", "an..7", "" )]
public string E8078 { get; set; }
		[ElementInfo(2, "Hazard code version number", "C", "", "an..10", "" )]
public string E8092 { get; set; }

    }
}