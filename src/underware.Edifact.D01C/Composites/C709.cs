using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01C.Composites
{
    public class C709
    {
				[ElementInfo(0, "Message type code", "M", "", "an..6", "" )]
public string E1475 { get; set; }
		[ElementInfo(1, "Version identifier", "C", "", "an..9", "" )]
public string E1056 { get; set; }
		[ElementInfo(2, "Release identifier", "C", "", "an..9", "" )]
public string E1058 { get; set; }
		[ElementInfo(3, "Controlling agency identifier", "C", "", "an..2", "" )]
public string E1476 { get; set; }
		[ElementInfo(4, "Message implementation identification code", "C", "", "an..6", "" )]
public string E1523 { get; set; }
		[ElementInfo(5, "Revision identifier", "C", "", "an..6", "" )]
public string E1060 { get; set; }
		[ElementInfo(6, "Document status code", "C", "", "an..3", "" )]
public string E1373 { get; set; }

    }
}