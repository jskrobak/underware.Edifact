using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class E989
    {
				[ElementInfo(0, "Product identifier", "C", "", "an..35", "" )]
public string E7135 { get; set; }
		[ElementInfo(1, "Characteristic description code", "C", "", "an..17", "" )]
public string E7037 { get; set; }
		[ElementInfo(2, "Product characteristic identification code", "C", "", "an..3", "" )]
public string E7139 { get; set; }
		[ElementInfo(3, "Item description identification", "C", "", "an..17", "" )]
public string E7009 { get; set; }
		[ElementInfo(4, "Item description identification", "C", "", "an..17", "" )]
public string E7009_0 { get; set; }
		[ElementInfo(5, "Item description identification", "C", "", "an..17", "" )]
public string E7009_1 { get; set; }
		[ElementInfo(6, "Product name", "C", "", "an..35", "" )]
public string E9608 { get; set; }

    }
}