using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C502
    {
				[ElementInfo(0, "Measured attribute code", "Conditional", "", "", "" )]
public string E6313 { get; set; }
		[ElementInfo(1, "Measurement significance code", "Conditional", "", "", "" )]
public string E6321 { get; set; }
		[ElementInfo(2, "Non-discrete measurement name code", "Conditional", "", "", "" )]
public string E6155 { get; set; }
		[ElementInfo(3, "Non-discrete measurement name", "Conditional", "", "", "" )]
public string E6154 { get; set; }

    }
}