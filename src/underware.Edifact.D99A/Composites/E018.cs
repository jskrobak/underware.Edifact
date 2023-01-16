using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class E018
    {
				[ElementInfo(0, "Price qualifier", "M", "", "an..3", "" )]
public string E5125 { get; set; }
		[ElementInfo(1, "Price", "C", "", "n..15", "" )]
public string E5118 { get; set; }
		[ElementInfo(2, "Price type, coded", "C", "", "an..3", "" )]
public string E5375 { get; set; }

    }
}