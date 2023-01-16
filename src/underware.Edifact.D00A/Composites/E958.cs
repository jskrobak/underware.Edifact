
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00A.Composites
{
    public class E958
    {
				[ElementInfo(0, "Quantity", "C", "", "an..35", "" )]
public string E6060 { get; set; }
		[ElementInfo(1, "Status description code", "C", "", "an..3", "" )]
public string E4405 { get; set; }

    }
}