using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03B.Composites
{
    public class C514
    {
				[ElementInfo(0, "Sample location description code", "C", "", "an..3", "" )]
public string E3237 { get; set; }
		[ElementInfo(1, "Sample location description", "C", "", "an..35", "" )]
public string E3236 { get; set; }

    }
}