using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02A.Composites
{
    public class E029
    {
				[ElementInfo(0, "Product identifier", "M", "", "an..35", "" )]
public string E7135 { get; set; }
		[ElementInfo(1, "Diagnosis type code", "C", "", "an..3", "" )]
public string E9623 { get; set; }
		[ElementInfo(2, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }

    }
}