using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class E985
    {
				[ElementInfo(0, "Surname", "M", "", "an..70", "" )]
public string E3500 { get; set; }
		[ElementInfo(1, "Party qualifier", "C", "", "an..3", "" )]
public string E3035 { get; set; }
		[ElementInfo(2, "Quantity", "C", "", "n..15", "" )]
public string E6060 { get; set; }
		[ElementInfo(3, "Status, coded", "C", "", "an..3", "" )]
public string E4405 { get; set; }
		[ElementInfo(4, "Language, coded", "C", "", "an..3", "" )]
public string E3453 { get; set; }

    }
}