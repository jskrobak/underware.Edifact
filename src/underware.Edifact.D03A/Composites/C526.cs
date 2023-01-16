using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03A.Composites
{
    public class C526
    {
				[ElementInfo(0, "Frequency code qualifier", "M", "", "an..3", "" )]
public string E6071 { get; set; }
		[ElementInfo(1, "Frequency rate", "C", "", "n..9", "" )]
public string E6072 { get; set; }
		[ElementInfo(2, "Measurement unit code", "C", "", "an..8", "" )]
public string E6411 { get; set; }

    }
}