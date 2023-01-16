using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class E003
    {
				[ElementInfo(0, "Attribute type identification", "M", "", "an..17", "" )]
public string E9021 { get; set; }
		[ElementInfo(1, "Attribute", "C", "", "an..35", "" )]
public string E9018 { get; set; }

    }
}