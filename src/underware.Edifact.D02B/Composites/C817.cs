using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02B.Composites
{
    public class C817
    {
				[ElementInfo(0, "Address purpose code", "C", "", "an..3", "" )]
public string E3299 { get; set; }
		[ElementInfo(1, "Address type code", "C", "", "an..3", "" )]
public string E3131 { get; set; }
		[ElementInfo(2, "Address status code", "C", "", "an..3", "" )]
public string E3475 { get; set; }

    }
}