
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00A.Composites
{
    public class E995
    {
				[ElementInfo(0, "Service requirement code", "C", "", "an..3", "" )]
public string E7273 { get; set; }
		[ElementInfo(1, "Date value", "C", "", "an..14", "" )]
public string E2000 { get; set; }
		[ElementInfo(2, "Time value", "C", "", "n4", "" )]
public string E2002 { get; set; }

    }
}