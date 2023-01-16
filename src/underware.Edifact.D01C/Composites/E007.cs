using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01C.Composites
{
    public class E007
    {
				[ElementInfo(0, "Traffic restriction code", "C", "", "an..3", "" )]
public string E8015 { get; set; }
		[ElementInfo(1, "Traffic restriction application code", "C", "", "an..3", "" )]
public string E8017 { get; set; }
		[ElementInfo(2, "Traffic restriction type code qualifier", "C", "", "an..3", "" )]
public string E8035 { get; set; }
		[ElementInfo(3, "Free text", "C", "", "an..512", "" )]
public string E4440 { get; set; }

    }
}