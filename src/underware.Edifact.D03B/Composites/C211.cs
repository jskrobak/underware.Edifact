using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03B.Composites
{
    public class C211
    {
				[ElementInfo(0, "Measurement unit code", "M", "", "an..8", "" )]
public string E6411 { get; set; }
		[ElementInfo(1, "Length measure", "C", "", "n..15", "" )]
public string E6168 { get; set; }
		[ElementInfo(2, "Width measure", "C", "", "n..15", "" )]
public string E6140 { get; set; }
		[ElementInfo(3, "Height measure", "C", "", "n..15", "" )]
public string E6008 { get; set; }

    }
}