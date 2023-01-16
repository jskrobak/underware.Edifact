using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01C.Composites
{
    public class C853
    {
				[ElementInfo(0, "Segment tag identifier", "C", "", "an..3", "" )]
public string E9166 { get; set; }
		[ElementInfo(1, "Sequence position identifier", "C", "", "an..10", "" )]
public string E1050 { get; set; }
		[ElementInfo(2, "Sequence identifier source code", "C", "", "an..3", "" )]
public string E1159 { get; set; }

    }
}