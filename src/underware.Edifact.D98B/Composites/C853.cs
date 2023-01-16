using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class C853
    {
				[ElementInfo(0, "Segment tag", "C", "", "an..3", "" )]
public string E9166 { get; set; }
		[ElementInfo(1, "Sequence number", "C", "", "an..10", "" )]
public string E1050 { get; set; }
		[ElementInfo(2, "Sequence number source, coded", "C", "", "an..3", "" )]
public string E1159 { get; set; }

    }
}