using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01C.Composites
{
    public class C090
    {
				[ElementInfo(0, "Address format code", "M", "", "an..3", "" )]
public string E3477 { get; set; }
		[ElementInfo(1, "Address component description", "M", "", "an..70", "" )]
public string E3286 { get; set; }
		[ElementInfo(2, "Address component description", "C", "", "an..70", "" )]
public string E3286_0 { get; set; }
		[ElementInfo(3, "Address component description", "C", "", "an..70", "" )]
public string E3286_1 { get; set; }
		[ElementInfo(4, "Address component description", "C", "", "an..70", "" )]
public string E3286_2 { get; set; }
		[ElementInfo(5, "Address component description", "C", "", "an..70", "" )]
public string E3286_3 { get; set; }

    }
}