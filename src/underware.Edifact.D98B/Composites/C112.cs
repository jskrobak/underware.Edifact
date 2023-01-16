using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class C112
    {
				[ElementInfo(0, "Payment time reference, coded", "M", "", "an..3", "" )]
public string E2475 { get; set; }
		[ElementInfo(1, "Time relation, coded", "C", "", "an..3", "" )]
public string E2009 { get; set; }
		[ElementInfo(2, "Type of period, coded", "C", "", "an..3", "" )]
public string E2151 { get; set; }
		[ElementInfo(3, "Number of periods", "C", "", "n..3", "" )]
public string E2152 { get; set; }

    }
}