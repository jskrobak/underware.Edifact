using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02B.Composites
{
    public class E010
    {
				[ElementInfo(0, "Option code", "M", "", "an..3", "" )]
public string E4009 { get; set; }
		[ElementInfo(1, "Related information description", "C", "", "an..35", "" )]
public string E4018 { get; set; }

    }
}