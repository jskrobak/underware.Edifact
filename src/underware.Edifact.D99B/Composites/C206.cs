using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class C206
    {
				[ElementInfo(0, "Object identifier", "M", "", "an..35", "" )]
public string E7402 { get; set; }
		[ElementInfo(1, "Object identification code qualifier", "C", "", "an..3", "" )]
public string E7405 { get; set; }
		[ElementInfo(2, "Status description code", "C", "", "an..3", "" )]
public string E4405 { get; set; }

    }
}