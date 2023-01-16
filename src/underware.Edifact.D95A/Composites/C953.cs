using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D95A.Composites
{
    public class C953
    {
				[ElementInfo(0, "Contribution type, coded", "M", "", "an..3", "" )]
public string E5049 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Contribution type", "C", "", "an..35", "" )]
public string E5048 { get; set; }

    }
}