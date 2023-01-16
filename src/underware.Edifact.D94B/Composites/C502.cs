using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D94B.Composites
{
    public class C502
    {
				[ElementInfo(0, "Measurement dimension, coded", "C", "", "an..3", "" )]
public string E6313 { get; set; }
		[ElementInfo(1, "Measurement significance, coded", "C", "", "an..3", "" )]
public string E6321 { get; set; }
		[ElementInfo(2, "Measurement attribute, coded", "C", "", "an..3", "" )]
public string E6155 { get; set; }
		[ElementInfo(3, "Measurement attribute", "C", "", "an..70", "" )]
public string E6154 { get; set; }

    }
}