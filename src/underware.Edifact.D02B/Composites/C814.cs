using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02B.Composites
{
    public class C814
    {
				[ElementInfo(0, "Safety section number", "M", "", "n..2", "" )]
public string E4046 { get; set; }
		[ElementInfo(1, "Safety section name", "C", "", "an..70", "" )]
public string E4044 { get; set; }

    }
}