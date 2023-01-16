using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class E010
    {
				[ElementInfo(0, "Option, coded", "M", "", "an..3", "" )]
public string E4009 { get; set; }
		[ElementInfo(1, "Associated option information", "C", "", "an..35", "" )]
public string E4018 { get; set; }

    }
}