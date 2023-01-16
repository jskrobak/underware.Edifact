using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03B.Composites
{
    public class C778
    {
				[ElementInfo(0, "Hierarchical structure level identifier", "C", "", "an..35", "" )]
public string E7164 { get; set; }
		[ElementInfo(1, "Sequence position identifier", "C", "", "an..10", "" )]
public string E1050 { get; set; }

    }
}