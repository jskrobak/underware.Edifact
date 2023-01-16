
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00A.Composites
{
    public class E211
    {
				[ElementInfo(0, "Measurement unit code", "M", "", "an..3", "" )]
public string E6411 { get; set; }
		[ElementInfo(1, "Length dimension value", "C", "", "n..15", "" )]
public string E6168 { get; set; }
		[ElementInfo(2, "Width dimension value", "C", "", "n..15", "" )]
public string E6140 { get; set; }
		[ElementInfo(3, "Height dimension value", "C", "", "n..15", "" )]
public string E6008 { get; set; }

    }
}