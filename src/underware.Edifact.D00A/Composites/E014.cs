
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00A.Composites
{
    public class E014
    {
				[ElementInfo(0, "Reference identifier", "C", "", "an..35", "" )]
public string E1154 { get; set; }
		[ElementInfo(1, "Reference function code qualifier", "C", "", "an..3", "" )]
public string E1153 { get; set; }

    }
}