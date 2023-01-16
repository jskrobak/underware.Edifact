using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C509
    {
				[ElementInfo(0, "Price code qualifier", "Mandatory", "", "", "" )]
public string E5125 { get; set; }
		[ElementInfo(1, "Price amount", "Conditional", "", "", "" )]
public string E5118 { get; set; }
		[ElementInfo(2, "Price type code", "Conditional", "", "", "" )]
public string E5375 { get; set; }
		[ElementInfo(3, "Price specification code", "Conditional", "", "", "" )]
public string E5387 { get; set; }
		[ElementInfo(4, "Unit price basis quantity", "Conditional", "", "", "" )]
public string E5284 { get; set; }
		[ElementInfo(5, "Measurement unit code", "Conditional", "", "", "" )]
public string E6411 { get; set; }

    }
}