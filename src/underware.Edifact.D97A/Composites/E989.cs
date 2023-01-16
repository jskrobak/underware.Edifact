using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D97A.Composites
{
    public class E989
    {
				[ElementInfo(0, "Product identification", "C", "", "an..35", "" )]
public string E7135 { get; set; }
		[ElementInfo(1, "Characteristic identification", "C", "", "an..17", "" )]
public string E7037 { get; set; }
		[ElementInfo(2, "Product identification characteristic, coded", "C", "", "an..3", "" )]
public string E7139 { get; set; }
		[ElementInfo(3, "Item description identification", "C", "", "an..17", "" )]
public string E7009 { get; set; }
		[ElementInfo(4, "Item description identification", "C", "", "an..17", "" )]
public string E7009_0 { get; set; }
		[ElementInfo(5, "Item description identification", "C", "", "an..17", "" )]
public string E7009_1 { get; set; }

    }
}