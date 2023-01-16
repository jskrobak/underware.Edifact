using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04B.Composites
{
    public class E959
    {
				[ElementInfo(0, "Special service description code", "M", "", "an..3", "" )]
public string E7161 { get; set; }
		[ElementInfo(1, "Time", "C", "", "n4", "" )]
public string E2002 { get; set; }
		[ElementInfo(2, "Time", "C", "", "n4", "" )]
public string E2002_0 { get; set; }
		[ElementInfo(3, "Date", "C", "", "an..14", "" )]
public string E2000 { get; set; }
		[ElementInfo(4, "Location name", "C", "", "an..256", "" )]
public string E3224 { get; set; }
		[ElementInfo(5, "Location name code", "C", "", "an..35", "" )]
public string E3225 { get; set; }
		[ElementInfo(6, "Location function code qualifier", "C", "", "an..3", "" )]
public string E3227 { get; set; }
		[ElementInfo(7, "Characteristic description code", "C", "", "an..17", "" )]
public string E7037 { get; set; }
		[ElementInfo(8, "First related location name code", "C", "", "an..25", "" )]
public string E3223 { get; set; }
		[ElementInfo(9, "Country name code", "C", "", "an..3", "" )]
public string E3207 { get; set; }
		[ElementInfo(10, "Special service description", "C", "", "an..35", "" )]
public string E7160 { get; set; }
		[ElementInfo(11, "Characteristic description", "C", "", "an..35", "" )]
public string E7036 { get; set; }
		[ElementInfo(12, "Action request/notification description code", "C", "", "an..3", "" )]
public string E1229 { get; set; }
		[ElementInfo(13, "Second related location name code", "C", "", "an..25", "" )]
public string E3233 { get; set; }
		[ElementInfo(14, "Language name code", "C", "", "an..3", "" )]
public string E3453 { get; set; }
		[ElementInfo(15, "Frequency rate", "C", "", "n..9", "" )]
public string E6072 { get; set; }
		[ElementInfo(16, "Measurement unit code", "C", "", "an..8", "" )]
public string E6411 { get; set; }
		[ElementInfo(17, "Quantity", "C", "", "an..35", "" )]
public string E6060 { get; set; }
		[ElementInfo(18, "Party name", "C", "", "an..35", "" )]
public string E3036 { get; set; }

    }
}