using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C174
    {
				[ElementInfo(0, "Measurement unit code", "Mandatory", "", "", "" )]
public string E6411 { get; set; }
		[ElementInfo(1, "Measure", "Conditional", "", "", "" )]
public string E6314 { get; set; }
		[ElementInfo(2, "Range minimum quantity", "Conditional", "", "", "" )]
public string E6162 { get; set; }
		[ElementInfo(3, "Range maximum quantity", "Conditional", "", "", "" )]
public string E6152 { get; set; }
		[ElementInfo(4, "Significant digits quantity", "Conditional", "", "", "" )]
public string E6432 { get; set; }

    }
}