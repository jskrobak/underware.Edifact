using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class C503
    {
				[ElementInfo(0, "Document/message number", "C", "", "an..35", "" )]
public string E1004 { get; set; }
		[ElementInfo(1, "Document/message status, coded", "C", "", "an..3", "" )]
public string E1373 { get; set; }
		[ElementInfo(2, "Document/message source", "C", "", "an..70", "" )]
public string E1366 { get; set; }
		[ElementInfo(3, "Language, coded", "C", "", "an..3", "" )]
public string E3453 { get; set; }
		[ElementInfo(4, "Version", "C", "", "an..9", "" )]
public string E1056 { get; set; }
		[ElementInfo(5, "Revision number", "C", "", "an..6", "" )]
public string E1060 { get; set; }

    }
}