using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C080
    {
				[ElementInfo(0, "Party name", "Mandatory", "", "", "" )]
public string E3036 { get; set; }
		[ElementInfo(1, "Party name", "Conditional", "", "", "" )]
public string E3036_0 { get; set; }
		[ElementInfo(2, "Party name", "Conditional", "", "", "" )]
public string E3036_1 { get; set; }
		[ElementInfo(3, "Party name", "Conditional", "", "", "" )]
public string E3036_2 { get; set; }
		[ElementInfo(4, "Party name", "Conditional", "", "", "" )]
public string E3036_3 { get; set; }
		[ElementInfo(5, "Party name format code", "Conditional", "", "", "" )]
public string E3045 { get; set; }

    }
}