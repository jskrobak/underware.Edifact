using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D03B.Composites
{
    public class C329
    {
				[ElementInfo(0, "Frequency code", "C", "", "an..3", "" )]
public string E2013 { get; set; }
		[ElementInfo(1, "Despatch pattern code", "C", "", "an..3", "" )]
public string E2015 { get; set; }
		[ElementInfo(2, "Despatch pattern timing code", "C", "", "an..3", "" )]
public string E2017 { get; set; }

    }
}