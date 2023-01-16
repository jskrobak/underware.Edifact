using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class C100
    {
				[ElementInfo(0, "Terms of delivery or transport, coded", "C", "", "an..3", "" )]
public string E4053 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Terms of delivery or transport", "C", "", "an..70", "" )]
public string E4052 { get; set; }
		[ElementInfo(4, "Terms of delivery or transport", "C", "", "an..70", "" )]
public string E4052_0 { get; set; }

    }
}