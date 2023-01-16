using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02A.Composites
{
    public class C852
    {
				[ElementInfo(0, "Risk object sub-type description identifier", "C", "", "an..17", "" )]
public string E7177 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Risk object sub-type description", "C", "", "an..70", "" )]
public string E7176 { get; set; }

    }
}