using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class E002
    {
				[ElementInfo(0, "Payment conditions, coded", "M", "", "an..3", "" )]
public string E4439 { get; set; }
		[ElementInfo(1, "Monetary amount", "C", "", "n..35", "" )]
public string E5004 { get; set; }
		[ElementInfo(2, "Currency, coded", "C", "", "an..3", "" )]
public string E6345 { get; set; }
		[ElementInfo(3, "Party name", "C", "", "an..35", "" )]
public string E3036 { get; set; }
		[ElementInfo(4, "Free text", "C", "", "an..70", "" )]
public string E4440 { get; set; }

    }
}