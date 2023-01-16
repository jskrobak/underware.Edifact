using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01C.Composites
{
    public class C523
    {
				[ElementInfo(0, "Units quantity", "C", "", "n..15", "" )]
public string E6350 { get; set; }
		[ElementInfo(1, "Unit type code qualifier", "C", "", "an..3", "" )]
public string E6353 { get; set; }

    }
}