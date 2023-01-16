using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01C.Composites
{
    public class E019
    {
				[ElementInfo(0, "Party name", "M", "", "an..35", "" )]
public string E3036 { get; set; }
		[ElementInfo(1, "Yes or no indicator code", "C", "", "an..3", "" )]
public string E9607 { get; set; }
		[ElementInfo(2, "Reference identifier", "C", "", "an..70", "" )]
public string E1154 { get; set; }
		[ElementInfo(3, "Free text", "C", "", "an..512", "" )]
public string E4440 { get; set; }
		[ElementInfo(4, "Free text", "C", "", "an..512", "" )]
public string E4440_0 { get; set; }
		[ElementInfo(5, "Free text", "C", "", "an..512", "" )]
public string E4440_1 { get; set; }
		[ElementInfo(6, "Free text", "C", "", "an..512", "" )]
public string E4440_2 { get; set; }
		[ElementInfo(7, "Free text", "C", "", "an..512", "" )]
public string E4440_3 { get; set; }

    }
}