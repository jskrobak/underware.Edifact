using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03B.Composites
{
    public class E967
    {
				[ElementInfo(0, "Reference code qualifier", "M", "", "an..3", "" )]
public string E1153 { get; set; }
		[ElementInfo(1, "Reference identifier", "C", "", "an..70", "" )]
public string E1154 { get; set; }
		[ElementInfo(2, "Party name", "C", "", "an..35", "" )]
public string E3036 { get; set; }
		[ElementInfo(3, "Traveller reference identifier", "C", "", "an..35", "" )]
public string E1145 { get; set; }

    }
}