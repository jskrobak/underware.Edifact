using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D94A.Composites
{
    public class C242
    {
				[ElementInfo(0, "Process type identification", "M", "", "an..17", "" )]
public string E7187 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Process type", "C", "", "an..35", "" )]
public string E7186 { get; set; }
		[ElementInfo(4, "Process type", "C", "", "an..35", "" )]
public string E7186_0 { get; set; }

    }
}