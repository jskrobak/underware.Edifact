using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D93A.Composites
{
    public class C526
    {
				[ElementInfo(0, "Frequency qualifier", "M", "", "an..3", "" )]
public string E6071 { get; set; }
		[ElementInfo(1, "Frequency value", "C", "", "n..9", "" )]
public string E6072 { get; set; }
		[ElementInfo(2, "Measure unit qualifier", "C", "", "an..3", "" )]
public string E6411 { get; set; }

    }
}