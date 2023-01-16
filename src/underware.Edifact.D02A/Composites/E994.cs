using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02A.Composites
{
    public class E994
    {
				[ElementInfo(0, "Location name code", "C", "", "an..35", "" )]
public string E3225 { get; set; }
		[ElementInfo(1, "Units quantity", "C", "", "n..15", "" )]
public string E6350 { get; set; }

    }
}