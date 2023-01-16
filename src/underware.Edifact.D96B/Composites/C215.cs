using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D96B.Composites
{
    public class C215
    {
				[ElementInfo(0, "Sealing party, coded", "C", "", "an..3", "" )]
public string E9303 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Sealing party", "C", "", "an..35", "" )]
public string E9302 { get; set; }

    }
}