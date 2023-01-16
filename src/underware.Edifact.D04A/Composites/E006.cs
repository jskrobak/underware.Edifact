using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04A.Composites
{
    public class E006
    {
				[ElementInfo(0, "Special condition code", "M", "", "an..3", "" )]
public string E4183 { get; set; }
		[ElementInfo(1, "Processing indicator description code", "C", "", "an..3", "" )]
public string E7365 { get; set; }

    }
}