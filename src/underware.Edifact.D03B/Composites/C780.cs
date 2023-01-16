using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03B.Composites
{
    public class C780
    {
				[ElementInfo(0, "Value list identifier", "M", "", "an..35", "" )]
public string E1518 { get; set; }
		[ElementInfo(1, "Object identification code qualifier", "C", "", "an..3", "" )]
public string E7405 { get; set; }

    }
}