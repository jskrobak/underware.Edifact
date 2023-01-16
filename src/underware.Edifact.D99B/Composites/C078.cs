using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class C078
    {
				[ElementInfo(0, "Account holder number", "C", "", "an..35", "" )]
public string E3194 { get; set; }
		[ElementInfo(1, "Account holder name", "C", "", "an..35", "" )]
public string E3192 { get; set; }
		[ElementInfo(2, "Account holder name", "C", "", "an..35", "" )]
public string E3192_0 { get; set; }
		[ElementInfo(3, "Currency identification code", "C", "", "an..3", "" )]
public string E6345 { get; set; }

    }
}