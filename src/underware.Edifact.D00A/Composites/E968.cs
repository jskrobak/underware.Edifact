
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00A.Composites
{
    public class E968
    {
				[ElementInfo(0, "Document name code", "M", "", "an..3", "" )]
public string E1001 { get; set; }
		[ElementInfo(1, "Document identifier", "C", "", "an..35", "" )]
public string E1004 { get; set; }
		[ElementInfo(2, "Characteristic value description code", "C", "", "an..3", "" )]
public string E7111 { get; set; }
		[ElementInfo(3, "Location name code", "C", "", "an..25", "" )]
public string E3225 { get; set; }
		[ElementInfo(4, "Country name code", "C", "", "an..3", "" )]
public string E3207 { get; set; }
		[ElementInfo(5, "Country name code", "C", "", "an..3", "" )]
public string E3207_0 { get; set; }

    }
}