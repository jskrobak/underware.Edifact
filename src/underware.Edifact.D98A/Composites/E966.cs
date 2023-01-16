using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98A.Composites
{
    public class E966
    {
				[ElementInfo(0, "Party qualifier", "M", "", "an..3", "" )]
public string E3035 { get; set; }
		[ElementInfo(1, "Communication number", "M", "", "an..512", "" )]
public string E3148 { get; set; }
		[ElementInfo(2, "Communication channel qualifier", "C", "", "an..3", "" )]
public string E3155 { get; set; }
		[ElementInfo(3, "Party name", "C", "", "an..35", "" )]
public string E3036 { get; set; }

    }
}