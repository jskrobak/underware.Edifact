using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C056
    {
				[ElementInfo(0, "Contact identifier", "Conditional", "", "", "" )]
public string E3413 { get; set; }
		[ElementInfo(1, "Contact name", "Conditional", "", "", "" )]
public string E3412 { get; set; }

    }
}