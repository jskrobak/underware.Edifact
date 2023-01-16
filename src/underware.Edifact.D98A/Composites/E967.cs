using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98A.Composites
{
    public class E967
    {
				[ElementInfo(0, "Reference qualifier", "M", "", "an..3", "" )]
public string E1153 { get; set; }
		[ElementInfo(1, "Reference number", "C", "", "an..35", "" )]
public string E1154 { get; set; }
		[ElementInfo(2, "Party name", "C", "", "an..35", "" )]
public string E3036 { get; set; }
		[ElementInfo(3, "Traveller reference number", "C", "", "an..35", "" )]
public string E1145 { get; set; }

    }
}