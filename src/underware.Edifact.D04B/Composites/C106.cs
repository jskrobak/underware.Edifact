using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04B.Composites
{
    public class C106
    {
				[ElementInfo(0, "Document identifier", "C", "", "an..35", "" )]
public string E1004 { get; set; }
		[ElementInfo(1, "Version identifier", "C", "", "an..9", "" )]
public string E1056 { get; set; }
		[ElementInfo(2, "Revision identifier", "C", "", "an..6", "" )]
public string E1060 { get; set; }

    }
}