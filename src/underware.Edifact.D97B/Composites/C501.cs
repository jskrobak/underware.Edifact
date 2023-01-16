using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D97B.Composites
{
    public class C501
    {
				[ElementInfo(0, "Percentage qualifier", "M", "", "an..3", "" )]
public string E5245 { get; set; }
		[ElementInfo(1, "Percentage", "C", "", "n..10", "" )]
public string E5482 { get; set; }
		[ElementInfo(2, "Percentage basis, coded", "C", "", "an..3", "" )]
public string E5249 { get; set; }
		[ElementInfo(3, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(4, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }

    }
}