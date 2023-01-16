using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class C232
    {
				[ElementInfo(0, "Government agency, coded", "C", "", "an..3", "" )]
public string E9415 { get; set; }
		[ElementInfo(1, "Government involvement, coded", "C", "", "an..3", "" )]
public string E9411 { get; set; }
		[ElementInfo(2, "Government action, coded", "C", "", "an..3", "" )]
public string E9417 { get; set; }
		[ElementInfo(3, "Government procedure, coded", "C", "", "an..3", "" )]
public string E9353 { get; set; }

    }
}