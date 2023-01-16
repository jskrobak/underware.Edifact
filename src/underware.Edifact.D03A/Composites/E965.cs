using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03A.Composites
{
    public class E965
    {
				[ElementInfo(0, "Facility type description code", "C", "", "an..3", "" )]
public string E9039 { get; set; }
		[ElementInfo(1, "Facility type description", "C", "", "an..70", "" )]
public string E9038 { get; set; }
		[ElementInfo(2, "Product details type code qualifier", "C", "", "an..3", "" )]
public string E7133 { get; set; }
		[ElementInfo(3, "Characteristic description code", "C", "", "an..17", "" )]
public string E7037 { get; set; }

    }
}