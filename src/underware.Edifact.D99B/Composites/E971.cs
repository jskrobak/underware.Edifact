using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class E971
    {
				[ElementInfo(0, "Text subject code qualifier", "M", "", "an..3", "" )]
public string E4451 { get; set; }
		[ElementInfo(1, "Information type identification", "C", "", "an..4", "" )]
public string E4473 { get; set; }
		[ElementInfo(2, "Status description code", "C", "", "an..3", "" )]
public string E4405 { get; set; }
		[ElementInfo(3, "Party name", "C", "", "an..35", "" )]
public string E3036 { get; set; }
		[ElementInfo(4, "Language name code", "C", "", "an..3", "" )]
public string E3453 { get; set; }

    }
}