using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class E965
    {
				[ElementInfo(0, "Facility type description code", "C", "", "an..3", "" )]
public string E9039 { get; set; }
		[ElementInfo(1, "Facility type description", "C", "", "an..70", "" )]
public string E9038 { get; set; }

    }
}