using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D97A.Composites
{
    public class E972
    {
				[ElementInfo(0, "Business function, coded", "C", "", "an..3", "" )]
public string E4025 { get; set; }
		[ElementInfo(1, "Message function, coded", "C", "", "an..3", "" )]
public string E1225 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }

    }
}