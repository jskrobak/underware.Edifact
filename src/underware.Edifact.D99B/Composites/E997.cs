using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class E997
    {
				[ElementInfo(0, "Reference identifier", "M", "", "an..35", "" )]
public string E1154 { get; set; }
		[ElementInfo(1, "Relationship description code", "C", "", "an..3", "" )]
public string E9143 { get; set; }
		[ElementInfo(2, "Special requirement type identification", "C", "", "an..4", "" )]
public string E4187 { get; set; }
		[ElementInfo(3, "Characteristic value, coded", "C", "", "an..3", "" )]
public string E7111 { get; set; }
		[ElementInfo(4, "Special requirement detail", "C", "", "an..17", "" )]
public string E4184 { get; set; }

    }
}