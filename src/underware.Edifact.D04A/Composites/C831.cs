using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04A.Composites
{
    public class C831
    {
				[ElementInfo(0, "Measure", "C", "", "an..18", "" )]
public string E6314 { get; set; }
		[ElementInfo(1, "Measurement significance code", "C", "", "an..3", "" )]
public string E6321 { get; set; }
		[ElementInfo(2, "Non-discrete measurement name code", "C", "", "an..17", "" )]
public string E6155 { get; set; }
		[ElementInfo(3, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(4, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(5, "Non-discrete measurement name", "C", "", "an..70", "" )]
public string E6154 { get; set; }

    }
}