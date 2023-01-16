using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class C088
    {
				[ElementInfo(0, "Institution name identification", "C", "", "an..11", "" )]
public string E3433 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Institution branch number", "C", "", "an..17", "" )]
public string E3434 { get; set; }
		[ElementInfo(4, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131_0 { get; set; }
		[ElementInfo(5, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055_0 { get; set; }
		[ElementInfo(6, "Institution name", "C", "", "an..70", "" )]
public string E3432 { get; set; }
		[ElementInfo(7, "Institution branch place", "C", "", "an..70", "" )]
public string E3436 { get; set; }

    }
}