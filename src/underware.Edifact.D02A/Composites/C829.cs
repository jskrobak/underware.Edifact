using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02A.Composites
{
    public class C829
    {
				[ElementInfo(0, "Sub-line indicator code", "C", "", "an..3", "" )]
public string E5495 { get; set; }
		[ElementInfo(1, "Line item identifier", "C", "", "an..6", "" )]
public string E1082 { get; set; }

    }
}