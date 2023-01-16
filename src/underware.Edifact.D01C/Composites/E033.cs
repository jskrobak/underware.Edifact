using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01C.Composites
{
    public class E033
    {
				[ElementInfo(0, "Language name code", "C", "", "an..3", "" )]
public string E3453 { get; set; }
		[ElementInfo(1, "Language name", "C", "", "an..35", "" )]
public string E3452 { get; set; }

    }
}