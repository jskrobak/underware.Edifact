using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02A.Composites
{
    public class E005
    {
				[ElementInfo(0, "Special condition code", "M", "", "an..3", "" )]
public string E4183 { get; set; }
		[ElementInfo(1, "Information type code", "C", "", "an..4", "" )]
public string E4473 { get; set; }
		[ElementInfo(2, "Free text", "C", "", "an..512", "" )]
public string E4440 { get; set; }

    }
}