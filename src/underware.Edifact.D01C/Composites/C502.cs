using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01C.Composites
{
    public class C502
    {
				[ElementInfo(0, "Measured attribute code", "C", "", "an..3", "" )]
public string E6313 { get; set; }
		[ElementInfo(1, "Measurement significance code", "C", "", "an..3", "" )]
public string E6321 { get; set; }
		[ElementInfo(2, "Non-discrete measurement name code", "C", "", "an..17", "" )]
public string E6155 { get; set; }
		[ElementInfo(3, "Non-discrete measurement name", "C", "", "an..70", "" )]
public string E6154 { get; set; }

    }
}