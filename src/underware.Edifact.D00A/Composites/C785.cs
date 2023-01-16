
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00A.Composites
{
    public class C785
    {
				[ElementInfo(0, "Statistical concept identifier", "M", "", "an..35", "" )]
public string E6434 { get; set; }
		[ElementInfo(1, "Object identification code qualifier", "C", "", "an..3", "" )]
public string E7405 { get; set; }

    }
}