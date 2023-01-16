using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class C106
    {
				[ElementInfo(0, "Document/message number", "C", "", "an..35", "" )]
public string E1004 { get; set; }
		[ElementInfo(1, "Version", "C", "", "an..9", "" )]
public string E1056 { get; set; }
		[ElementInfo(2, "Revision number", "C", "", "an..6", "" )]
public string E1060 { get; set; }

    }
}