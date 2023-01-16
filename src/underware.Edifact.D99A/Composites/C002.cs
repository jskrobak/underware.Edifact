using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class C002
    {
				[ElementInfo(0, "Document/message name, coded", "C", "", "an..3", "" )]
public string E1001 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Document/message name", "C", "", "an..35", "" )]
public string E1000 { get; set; }

    }
}