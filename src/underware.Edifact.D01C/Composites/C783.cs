using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01C.Composites
{
    public class C783
    {
				[ElementInfo(0, "Footnote set identifier", "M", "", "an..35", "" )]
public string E9430 { get; set; }
		[ElementInfo(1, "Object identification code qualifier", "C", "", "an..3", "" )]
public string E7405 { get; set; }

    }
}