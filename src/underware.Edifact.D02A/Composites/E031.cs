using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02A.Composites
{
    public class E031
    {
				[ElementInfo(0, "Message function code", "C", "", "an..3", "" )]
public string E1225 { get; set; }
		[ElementInfo(1, "Process description code", "C", "", "an..17", "" )]
public string E7191 { get; set; }
		[ElementInfo(2, "Process description code", "C", "", "an..17", "" )]
public string E7191_0 { get; set; }

    }
}