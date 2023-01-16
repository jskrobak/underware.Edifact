using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98A.Composites
{
    public class C402
    {
				[ElementInfo(0, "Item description type, coded", "M", "", "an..3", "" )]
public string E7077 { get; set; }
		[ElementInfo(1, "Type of packages", "M", "", "an..35", "" )]
public string E7064 { get; set; }
		[ElementInfo(2, "Item number type, coded", "C", "", "an..3", "" )]
public string E7143 { get; set; }
		[ElementInfo(3, "Type of packages", "C", "", "an..35", "" )]
public string E7064_0 { get; set; }
		[ElementInfo(4, "Item number type, coded", "C", "", "an..3", "" )]
public string E7143_0 { get; set; }

    }
}