using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98A.Composites
{
    public class C186
    {
				[ElementInfo(0, "Quantity qualifier", "M", "", "an..3", "" )]
public string E6063 { get; set; }
		[ElementInfo(1, "Quantity", "M", "", "n..15", "" )]
public string E6060 { get; set; }
		[ElementInfo(2, "Measure unit qualifier", "C", "", "an..3", "" )]
public string E6411 { get; set; }

    }
}