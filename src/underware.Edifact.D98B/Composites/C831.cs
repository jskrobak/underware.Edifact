using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class C831
    {
				[ElementInfo(0, "Measurement value", "C", "", "an..18", "" )]
public string E6314 { get; set; }
		[ElementInfo(1, "Measurement significance, coded", "C", "", "an..3", "" )]
public string E6321 { get; set; }
		[ElementInfo(2, "Measurement attribute identification", "C", "", "an..17", "" )]
public string E6155 { get; set; }
		[ElementInfo(3, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(4, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(5, "Measurement attribute", "C", "", "an..70", "" )]
public string E6154 { get; set; }

    }
}