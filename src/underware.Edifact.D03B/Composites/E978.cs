using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03B.Composites
{
    public class E978
    {
				[ElementInfo(0, "Party name", "M", "", "an..35", "" )]
public string E3036 { get; set; }
		[ElementInfo(1, "Reference identifier", "C", "", "an..70", "" )]
public string E1154 { get; set; }
		[ElementInfo(2, "Date", "C", "", "an..14", "" )]
public string E2000 { get; set; }
		[ElementInfo(3, "Bank identifier", "C", "", "an..17", "" )]
public string E3449 { get; set; }
		[ElementInfo(4, "Traveller reference identifier", "C", "", "an..35", "" )]
public string E1145 { get; set; }

    }
}