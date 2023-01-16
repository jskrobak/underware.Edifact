using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C280
    {
				[ElementInfo(0, "Measurement unit code", "Mandatory", "", "", "" )]
public string E6411 { get; set; }
		[ElementInfo(1, "Range minimum quantity", "Conditional", "", "", "" )]
public string E6162 { get; set; }
		[ElementInfo(2, "Range maximum quantity", "Conditional", "", "", "" )]
public string E6152 { get; set; }

    }
}