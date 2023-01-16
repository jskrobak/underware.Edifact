using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04A.Composites
{
    public class C838
    {
				[ElementInfo(0, "Dosage description identifier", "C", "", "an..8", "" )]
public string E6083 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Dosage description", "C", "", "an..70", "" )]
public string E6082 { get; set; }

    }
}