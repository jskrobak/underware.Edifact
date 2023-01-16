using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03B.Composites
{
    public class E987
    {
				[ElementInfo(0, "Date", "C", "", "an..14", "" )]
public string E2000 { get; set; }
		[ElementInfo(1, "Time", "C", "", "n4", "" )]
public string E2002 { get; set; }
		[ElementInfo(2, "Date", "C", "", "an..14", "" )]
public string E2000_0 { get; set; }
		[ElementInfo(3, "Time", "C", "", "n4", "" )]
public string E2002_0 { get; set; }
		[ElementInfo(4, "Date variation number", "C", "", "n..5", "" )]
public string E2148 { get; set; }

    }
}