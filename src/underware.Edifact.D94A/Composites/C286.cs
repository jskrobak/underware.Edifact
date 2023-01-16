using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D94A.Composites
{
    public class C286
    {
				[ElementInfo(0, "Sequence number", "M", "", "an..6", "" )]
public string E1050 { get; set; }
		[ElementInfo(1, "Sequence number source, coded", "C", "", "an..3", "" )]
public string E1159 { get; set; }
		[ElementInfo(2, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(3, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }

    }
}