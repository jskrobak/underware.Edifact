using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class C878
    {
				[ElementInfo(0, "Institution branch number", "M", "", "an..17", "" )]
public string E3434 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Account holder number", "C", "", "an..35", "" )]
public string E3194 { get; set; }
		[ElementInfo(4, "Currency, coded", "C", "", "an..3", "" )]
public string E6345 { get; set; }

    }
}