using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D93A.Composites
{
    public class C056
    {
				[ElementInfo(0, "Department or employee identification", "C", "", "an..17", "" )]
public string E3413 { get; set; }
		[ElementInfo(1, "Department or employee", "C", "", "an..35", "" )]
public string E3412 { get; set; }

    }
}