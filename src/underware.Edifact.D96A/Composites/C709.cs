using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D96A.Composites
{
    public class C709
    {
				[ElementInfo(0, "Message type identifier", "M", "", "an..6", "" )]
public string E1475 { get; set; }
		[ElementInfo(1, "Version", "M", "", "an..9", "" )]
public string E1056 { get; set; }
		[ElementInfo(2, "Release", "M", "", "an..9", "" )]
public string E1058 { get; set; }
		[ElementInfo(3, "Control agency", "M", "", "an..2", "" )]
public string E1476 { get; set; }
		[ElementInfo(4, "Association assigned identification", "C", "", "an..6", "" )]
public string E1523 { get; set; }
		[ElementInfo(5, "Revision number", "C", "", "an..6", "" )]
public string E1060 { get; set; }

    }
}