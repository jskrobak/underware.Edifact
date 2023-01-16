using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04A.Composites
{
    public class C945
    {
				[ElementInfo(0, "Membership level code qualifier", "M", "", "an..3", "" )]
public string E7455 { get; set; }
		[ElementInfo(1, "Membership level description code", "C", "", "an..9", "" )]
public string E7457 { get; set; }
		[ElementInfo(2, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(3, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(4, "Membership level description", "C", "", "an..35", "" )]
public string E7456 { get; set; }

    }
}