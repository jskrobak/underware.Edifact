using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class E970
    {
				[ElementInfo(0, "Party name", "M", "", "an..35", "" )]
public string E3036 { get; set; }
		[ElementInfo(1, "Frequent traveller identification", "M", "", "an..25", "" )]
public string E3459 { get; set; }
		[ElementInfo(2, "Traveller reference number", "C", "", "an..35", "" )]
public string E1145 { get; set; }

    }
}