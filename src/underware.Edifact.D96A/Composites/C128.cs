using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D96A.Composites
{
    public class C128
    {
				[ElementInfo(0, "Rate type qualifier", "M", "", "an..3", "" )]
public string E5419 { get; set; }
		[ElementInfo(1, "Rate per unit", "M", "", "n..15", "" )]
public string E5420 { get; set; }
		[ElementInfo(2, "Unit price basis", "C", "", "n..9", "" )]
public string E5284 { get; set; }
		[ElementInfo(3, "Measure unit qualifier", "C", "", "an..3", "" )]
public string E6411 { get; set; }

    }
}