using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class E523
    {
				[ElementInfo(0, "Number of units", "C", "", "n..15", "" )]
public string E6350 { get; set; }
		[ElementInfo(1, "Unit type code qualifier", "C", "", "an..3", "" )]
public string E6353 { get; set; }

    }
}