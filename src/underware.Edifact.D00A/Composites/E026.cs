
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00A.Composites
{
    public class E026
    {
				[ElementInfo(0, "Admission type description code", "C", "", "an..3", "" )]
public string E9445 { get; set; }
		[ElementInfo(1, "Admission source code", "C", "", "an..3", "" )]
public string E9627 { get; set; }

    }
}