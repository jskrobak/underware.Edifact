using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04B.Composites
{
    public class C099
    {
				[ElementInfo(0, "File format name", "M", "", "an..17", "" )]
public string E1516 { get; set; }
		[ElementInfo(1, "Version identifier", "C", "", "an..9", "" )]
public string E1056 { get; set; }
		[ElementInfo(2, "Data format description code", "C", "", "an..3", "" )]
public string E1503 { get; set; }
		[ElementInfo(3, "Data format description", "C", "", "an..35", "" )]
public string E1502 { get; set; }

    }
}