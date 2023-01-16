using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04B.Composites
{
    public class E024
    {
				[ElementInfo(0, "Supporting evidence type code qualifier", "M", "", "an..3", "" )]
public string E9643 { get; set; }
		[ElementInfo(1, "Reference identifier", "M", "", "an..70", "" )]
public string E1154 { get; set; }
		[ElementInfo(2, "Communication medium type code", "C", "", "an..3", "" )]
public string E3153 { get; set; }

    }
}