using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class C509
    {
				[ElementInfo(0, "Price qualifier", "M", "", "an..3", "" )]
public string E5125 { get; set; }
		[ElementInfo(1, "Price", "C", "", "n..15", "" )]
public string E5118 { get; set; }
		[ElementInfo(2, "Price type, coded", "C", "", "an..3", "" )]
public string E5375 { get; set; }
		[ElementInfo(3, "Price type qualifier", "C", "", "an..3", "" )]
public string E5387 { get; set; }
		[ElementInfo(4, "Unit price basis", "C", "", "n..9", "" )]
public string E5284 { get; set; }
		[ElementInfo(5, "Measure unit qualifier", "C", "", "an..3", "" )]
public string E6411 { get; set; }

    }
}