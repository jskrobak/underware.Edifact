using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class E778
    {
				[ElementInfo(0, "Hierarchical id. number", "C", "", "an..12", "" )]
public string E7164 { get; set; }
		[ElementInfo(1, "Sequence number", "C", "", "an..10", "" )]
public string E1050 { get; set; }

    }
}