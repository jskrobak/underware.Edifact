using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04A.Composites
{
    public class C242
    {
				[ElementInfo(0, "Process type description code", "M", "", "an..17", "" )]
public string E7187 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Process type description", "C", "", "an..35", "" )]
public string E7186 { get; set; }
		[ElementInfo(4, "Process type description", "C", "", "an..35", "" )]
public string E7186_0 { get; set; }

    }
}