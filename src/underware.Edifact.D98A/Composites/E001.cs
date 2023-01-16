using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98A.Composites
{
    public class E001
    {
				[ElementInfo(0, "Address format, coded", "M", "", "an..3", "" )]
public string E3477 { get; set; }
		[ElementInfo(1, "Address component", "M", "", "an..70", "" )]
public string E3286 { get; set; }
		[ElementInfo(2, "Address component", "C", "", "an..70", "" )]
public string E3286_0 { get; set; }
		[ElementInfo(3, "Address component", "C", "", "an..70", "" )]
public string E3286_1 { get; set; }
		[ElementInfo(4, "Address component", "C", "", "an..70", "" )]
public string E3286_2 { get; set; }
		[ElementInfo(5, "Address component", "C", "", "an..70", "" )]
public string E3286_3 { get; set; }
		[ElementInfo(6, "Address component", "C", "", "an..70", "" )]
public string E3286_4 { get; set; }

    }
}