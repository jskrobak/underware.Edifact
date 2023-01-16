using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class C077
    {
				[ElementInfo(0, "File name", "C", "", "an..35", "" )]
public string E1508 { get; set; }
		[ElementInfo(1, "Item description", "C", "", "an..256", "" )]
public string E7008 { get; set; }

    }
}