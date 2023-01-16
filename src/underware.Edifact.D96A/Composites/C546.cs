using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D96A.Composites
{
    public class C546
    {
				[ElementInfo(0, "Index value", "M", "", "n..6", "" )]
public string E5030 { get; set; }
		[ElementInfo(1, "Index value representation, coded", "C", "", "an..3", "" )]
public string E5039 { get; set; }

    }
}