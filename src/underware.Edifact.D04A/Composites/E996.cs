using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04A.Composites
{
    public class E996
    {
				[ElementInfo(0, "Characteristic description code", "C", "", "an..17", "" )]
public string E7037 { get; set; }
		[ElementInfo(1, "Requested information description", "C", "", "an..35", "" )]
public string E4510 { get; set; }
		[ElementInfo(2, "Special service description code", "C", "", "an..3", "" )]
public string E7161 { get; set; }
		[ElementInfo(3, "Item description code", "C", "", "an..17", "" )]
public string E7009 { get; set; }
		[ElementInfo(4, "Item description code", "C", "", "an..17", "" )]
public string E7009_0 { get; set; }
		[ElementInfo(5, "Item description code", "C", "", "an..17", "" )]
public string E7009_1 { get; set; }

    }
}