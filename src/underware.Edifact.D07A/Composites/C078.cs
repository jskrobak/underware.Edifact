using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C078
    {
				[ElementInfo(0, "Account holder identifier", "Conditional", "", "", "" )]
public string E3194 { get; set; }
		[ElementInfo(1, "Account holder name", "Conditional", "", "", "" )]
public string E3192 { get; set; }
		[ElementInfo(2, "Account holder name", "Conditional", "", "", "" )]
public string E3192_0 { get; set; }
		[ElementInfo(3, "Currency identification code", "Conditional", "", "", "" )]
public string E6345 { get; set; }

    }
}