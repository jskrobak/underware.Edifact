using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class E981
    {
				[ElementInfo(0, "Special requirement detail", "C", "", "an..17", "" )]
public string E4184 { get; set; }
		[ElementInfo(1, "Measure unit qualifier", "C", "", "an..3", "" )]
public string E6411 { get; set; }
		[ElementInfo(2, "Quantity", "C", "", "n..15", "" )]
public string E6060 { get; set; }
		[ElementInfo(3, "Traveller reference number", "C", "", "an..35", "" )]
public string E1145 { get; set; }
		[ElementInfo(4, "Characteristic value, coded", "C", "", "an..3", "" )]
public string E7111 { get; set; }
		[ElementInfo(5, "Characteristic value, coded", "C", "", "an..3", "" )]
public string E7111_0 { get; set; }
		[ElementInfo(6, "Characteristic value, coded", "C", "", "an..3", "" )]
public string E7111_1 { get; set; }
		[ElementInfo(7, "Characteristic value, coded", "C", "", "an..3", "" )]
public string E7111_2 { get; set; }
		[ElementInfo(8, "Characteristic value, coded", "C", "", "an..3", "" )]
public string E7111_3 { get; set; }

    }
}