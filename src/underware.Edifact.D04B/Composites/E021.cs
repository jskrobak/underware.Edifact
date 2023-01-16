using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04B.Composites
{
    public class E021
    {
				[ElementInfo(0, "Product identifier", "M", "", "an..35", "" )]
public string E7135 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Procedure modification code", "C", "", "an..3", "" )]
public string E9629 { get; set; }
		[ElementInfo(3, "Procedure modification code", "C", "", "an..3", "" )]
public string E9629_0 { get; set; }
		[ElementInfo(4, "Procedure modification code", "C", "", "an..3", "" )]
public string E9629_1 { get; set; }
		[ElementInfo(5, "Procedure modification code", "C", "", "an..3", "" )]
public string E9629_2 { get; set; }

    }
}