using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D95A.Composites
{
    public class C237
    {
				[ElementInfo(0, "Equipment identification number", "C", "", "an..17", "" )]
public string E8260 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Country, coded", "C", "", "an..3", "" )]
public string E3207 { get; set; }

    }
}