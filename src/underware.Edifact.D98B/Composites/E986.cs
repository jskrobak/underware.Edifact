using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class E986
    {
				[ElementInfo(0, "Given name", "C", "", "an..70", "" )]
public string E3460 { get; set; }
		[ElementInfo(1, "Party qualifier", "C", "", "an..3", "" )]
public string E3035 { get; set; }
		[ElementInfo(2, "Traveller reference number", "C", "", "an..35", "" )]
public string E1145 { get; set; }
		[ElementInfo(3, "Title", "C", "", "an..9", "" )]
public string E3504 { get; set; }
		[ElementInfo(4, "Traveller accompanied by infant indicator", "C", "", "an1", "" )]
public string E8219 { get; set; }
		[ElementInfo(5, "Language, coded", "C", "", "an..3", "" )]
public string E3453 { get; set; }
		[ElementInfo(6, "Sex, coded", "C", "", "an..3", "" )]
public string E3499 { get; set; }
		[ElementInfo(7, "Age", "C", "", "n..3", "" )]
public string E2018 { get; set; }

    }
}