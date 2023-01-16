using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03A.Composites
{
    public class C279
    {
				[ElementInfo(0, "Variance quantity", "M", "", "n..15", "" )]
public string E6064 { get; set; }
		[ElementInfo(1, "Quantity type code qualifier", "C", "", "an..3", "" )]
public string E6063 { get; set; }

    }
}