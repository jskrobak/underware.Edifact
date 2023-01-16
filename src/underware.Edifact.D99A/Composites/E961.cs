using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class E961
    {
				[ElementInfo(0, "Type of means of transport identification", "C", "", "an..8", "" )]
public string E8179 { get; set; }
		[ElementInfo(1, "Number of stops", "C", "", "n..3", "" )]
public string E8216 { get; set; }
		[ElementInfo(2, "Leg duration", "C", "", "an..6", "" )]
public string E2162 { get; set; }
		[ElementInfo(3, "Percentage", "C", "", "n..10", "" )]
public string E5482 { get; set; }
		[ElementInfo(4, "Days of operation", "C", "", "an..7", "" )]
public string E2160 { get; set; }
		[ElementInfo(5, "Date/time/period", "C", "", "an..35", "" )]
public string E2380 { get; set; }
		[ElementInfo(6, "Complexing transport indicator", "C", "", "an1", "" )]
public string E8215 { get; set; }
		[ElementInfo(7, "Place/location identification", "C", "", "an..25", "" )]
public string E3225 { get; set; }
		[ElementInfo(8, "Place/location identification", "C", "", "an..25", "" )]
public string E3225_0 { get; set; }
		[ElementInfo(9, "Place/location identification", "C", "", "an..25", "" )]
public string E3225_1 { get; set; }

    }
}