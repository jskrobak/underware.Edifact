using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D94A.Composites
{
    public class C506
    {
				[ElementInfo(0, "Reference qualifier", "M", "", "an..3", "" )]
public string E1153 { get; set; }
		[ElementInfo(1, "Reference number", "C", "", "an..35", "" )]
public string E1154 { get; set; }
		[ElementInfo(2, "Line number", "C", "", "an..6", "" )]
public string E1156 { get; set; }
		[ElementInfo(3, "Reference version number", "C", "", "an..35", "" )]
public string E4000 { get; set; }

    }
}