using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98A.Composites
{
    public class E007
    {
				[ElementInfo(0, "Traffic restriction, coded", "C", "", "an..3", "" )]
public string E8015 { get; set; }
		[ElementInfo(1, "Traffic restriction type, coded", "C", "", "an..3", "" )]
public string E8017 { get; set; }
		[ElementInfo(2, "Traffic restriction type qualifier", "C", "", "an..3", "" )]
public string E8035 { get; set; }
		[ElementInfo(3, "Free text", "C", "", "an..70", "" )]
public string E4440 { get; set; }

    }
}