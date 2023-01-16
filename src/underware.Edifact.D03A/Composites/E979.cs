using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03A.Composites
{
    public class E979
    {
				[ElementInfo(0, "Party name", "C", "", "an..35", "" )]
public string E3036 { get; set; }
		[ElementInfo(1, "Reservation identifier", "C", "", "an..20", "" )]
public string E9040 { get; set; }
		[ElementInfo(2, "Reservation identifier code qualifier", "C", "", "an..3", "" )]
public string E9043 { get; set; }
		[ElementInfo(3, "Date", "C", "", "an..14", "" )]
public string E2000 { get; set; }
		[ElementInfo(4, "Millisecond time", "C", "", "n9", "" )]
public string E2164 { get; set; }
		[ElementInfo(5, "Reference identifier", "C", "", "an..70", "" )]
public string E1154 { get; set; }
		[ElementInfo(6, "Adjustment reason description code", "C", "", "an..3", "" )]
public string E4465 { get; set; }

    }
}