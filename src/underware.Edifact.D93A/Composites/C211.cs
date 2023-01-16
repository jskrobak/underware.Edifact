using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D93A.Composites
{
    public class C211
    {
				[ElementInfo(0, "Measure unit qualifier", "M", "", "an..3", "" )]
public string E6411 { get; set; }
		[ElementInfo(1, "Length dimension", "C", "", "n..15", "" )]
public string E6168 { get; set; }
		[ElementInfo(2, "Width dimension", "C", "", "n..15", "" )]
public string E6140 { get; set; }
		[ElementInfo(3, "Height dimension", "C", "", "n..15", "" )]
public string E6008 { get; set; }

    }
}