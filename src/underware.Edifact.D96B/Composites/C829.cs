using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D96B.Composites
{
    public class C829
    {
				[ElementInfo(0, "Sub-line indicator, coded", "C", "", "an..3", "" )]
public string E5495 { get; set; }
		[ElementInfo(1, "Line item number", "C", "", "n..6", "" )]
public string E1082 { get; set; }

    }
}