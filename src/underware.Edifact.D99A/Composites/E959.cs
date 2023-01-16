using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class E959
    {
				[ElementInfo(0, "Special services, coded", "M", "", "an..3", "" )]
public string E7161 { get; set; }
		[ElementInfo(1, "Time", "C", "", "n4", "" )]
public string E2002 { get; set; }
		[ElementInfo(2, "Time", "C", "", "n4", "" )]
public string E2002_0 { get; set; }
		[ElementInfo(3, "Date", "C", "", "an..14", "" )]
public string E2000 { get; set; }
		[ElementInfo(4, "Place/location", "C", "", "an..70", "" )]
public string E3224 { get; set; }
		[ElementInfo(5, "Place/location identification", "C", "", "an..25", "" )]
public string E3225 { get; set; }
		[ElementInfo(6, "Place/location qualifier", "C", "", "an..3", "" )]
public string E3227 { get; set; }
		[ElementInfo(7, "Characteristic identification", "C", "", "an..17", "" )]
public string E7037 { get; set; }
		[ElementInfo(8, "Related place/location one identification", "C", "", "an..25", "" )]
public string E3223 { get; set; }
		[ElementInfo(9, "Country, coded", "C", "", "an..3", "" )]
public string E3207 { get; set; }
		[ElementInfo(10, "Special service", "C", "", "an..35", "" )]
public string E7160 { get; set; }
		[ElementInfo(11, "Characteristic", "C", "", "an..35", "" )]
public string E7036 { get; set; }

    }
}