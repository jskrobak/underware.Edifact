using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D93A.Composites
{
    public class C504
    {
				[ElementInfo(0, "Currency details qualifier", "M", "", "an..3", "" )]
public string E6347 { get; set; }
		[ElementInfo(1, "Currency, coded", "C", "", "an..3", "" )]
public string E6345 { get; set; }
		[ElementInfo(2, "Currency qualifier", "C", "", "an..3", "" )]
public string E6343 { get; set; }
		[ElementInfo(3, "Currency rate base", "C", "", "n..4", "" )]
public string E6348 { get; set; }

    }
}