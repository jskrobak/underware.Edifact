using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01C.Composites
{
    public class E998
    {
				[ElementInfo(0, "Adjustment reason description code", "M", "", "an..3", "" )]
public string E4465 { get; set; }
		[ElementInfo(1, "Percentage", "C", "", "n..10", "" )]
public string E5482 { get; set; }
		[ElementInfo(2, "Party name", "C", "", "an..35", "" )]
public string E3036 { get; set; }
		[ElementInfo(3, "Units quantity", "C", "", "n..15", "" )]
public string E6350 { get; set; }

    }
}