using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C128
    {
				[ElementInfo(0, "Rate type code qualifier", "Mandatory", "", "", "" )]
public string E5419 { get; set; }
		[ElementInfo(1, "Unit price basis rate", "Mandatory", "", "", "" )]
public string E5420 { get; set; }
		[ElementInfo(2, "Unit price basis quantity", "Conditional", "", "", "" )]
public string E5284 { get; set; }
		[ElementInfo(3, "Measurement unit code", "Conditional", "", "", "" )]
public string E6411 { get; set; }

    }
}