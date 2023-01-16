using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D96B.Composites
{
    public class C099
    {
				[ElementInfo(0, "File format", "M", "", "an..17", "" )]
public string E1516 { get; set; }
		[ElementInfo(1, "Version", "C", "", "an..9", "" )]
public string E1056 { get; set; }
		[ElementInfo(2, "Data format, coded", "C", "", "an..3", "" )]
public string E1503 { get; set; }
		[ElementInfo(3, "Data format", "C", "", "an..35", "" )]
public string E1502 { get; set; }

    }
}