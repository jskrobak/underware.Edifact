using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D95B.Composites
{
    public class C329
    {
				[ElementInfo(0, "Frequency, coded", "C", "", "an..3", "" )]
public string E2013 { get; set; }
		[ElementInfo(1, "Despatch pattern, coded", "C", "", "an..3", "" )]
public string E2015 { get; set; }
		[ElementInfo(2, "Despatch pattern timing, coded", "C", "", "an..3", "" )]
public string E2017 { get; set; }

    }
}