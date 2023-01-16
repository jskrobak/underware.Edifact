using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03A.Composites
{
    public class E032
    {
				[ElementInfo(0, "Party identifier", "C", "", "an..35", "" )]
public string E3039 { get; set; }
		[ElementInfo(1, "Party function code qualifier", "C", "", "an..3", "" )]
public string E3035 { get; set; }

    }
}