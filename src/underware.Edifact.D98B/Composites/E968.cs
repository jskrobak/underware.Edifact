using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class E968
    {
				[ElementInfo(0, "Document/message name, coded", "M", "", "an..3", "" )]
public string E1001 { get; set; }
		[ElementInfo(1, "Document/message number", "M", "", "an..35", "" )]
public string E1004 { get; set; }
		[ElementInfo(2, "Characteristic value, coded", "C", "", "an..3", "" )]
public string E7111 { get; set; }
		[ElementInfo(3, "Place/location identification", "C", "", "an..25", "" )]
public string E3225 { get; set; }
		[ElementInfo(4, "Country, coded", "C", "", "an..3", "" )]
public string E3207 { get; set; }
		[ElementInfo(5, "Country, coded", "C", "", "an..3", "" )]
public string E3207_0 { get; set; }

    }
}