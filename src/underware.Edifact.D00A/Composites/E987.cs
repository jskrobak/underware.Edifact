
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00A.Composites
{
    public class E987
    {
				[ElementInfo(0, "Date value", "C", "", "an..14", "" )]
public string E2000 { get; set; }
		[ElementInfo(1, "Time value", "C", "", "n4", "" )]
public string E2002 { get; set; }
		[ElementInfo(2, "Date value", "C", "", "an..14", "" )]
public string E2000_0 { get; set; }
		[ElementInfo(3, "Time value", "C", "", "n4", "" )]
public string E2002_0 { get; set; }
		[ElementInfo(4, "Date variation number", "C", "", "n..5", "" )]
public string E2148 { get; set; }

    }
}