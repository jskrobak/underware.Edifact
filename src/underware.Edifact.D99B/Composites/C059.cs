using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class C059
    {
				[ElementInfo(0, "Street and number/p.o. box", "M", "", "an..35", "" )]
public string E3042 { get; set; }
		[ElementInfo(1, "Street and number/p.o. box", "C", "", "an..35", "" )]
public string E3042_0 { get; set; }
		[ElementInfo(2, "Street and number/p.o. box", "C", "", "an..35", "" )]
public string E3042_1 { get; set; }
		[ElementInfo(3, "Street and number/p.o. box", "C", "", "an..35", "" )]
public string E3042_2 { get; set; }

    }
}