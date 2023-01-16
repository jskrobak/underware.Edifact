using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class E003
    {
				[ElementInfo(0, "Attribute type, coded", "M", "", "an..3", "" )]
public string E9021 { get; set; }
		[ElementInfo(1, "Attribute", "C", "", "an..35", "" )]
public string E9018 { get; set; }

    }
}