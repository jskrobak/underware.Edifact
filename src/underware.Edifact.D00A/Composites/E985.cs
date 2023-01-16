
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00A.Composites
{
    public class E985
    {
				[ElementInfo(0, "Family name", "M", "", "an..70", "" )]
public string E3500 { get; set; }
		[ElementInfo(1, "Party function code qualifier", "C", "", "an..3", "" )]
public string E3035 { get; set; }
		[ElementInfo(2, "Quantity", "C", "", "an..35", "" )]
public string E6060 { get; set; }
		[ElementInfo(3, "Status description code", "C", "", "an..3", "" )]
public string E4405 { get; set; }
		[ElementInfo(4, "Language name code", "C", "", "an..3", "" )]
public string E3453 { get; set; }

    }
}