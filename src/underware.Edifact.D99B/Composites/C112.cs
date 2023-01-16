using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class C112
    {
				[ElementInfo(0, "Time reference code", "M", "", "an..3", "" )]
public string E2475 { get; set; }
		[ElementInfo(1, "Terms time relation code", "C", "", "an..3", "" )]
public string E2009 { get; set; }
		[ElementInfo(2, "Period type code", "C", "", "an..3", "" )]
public string E2151 { get; set; }
		[ElementInfo(3, "Period count quantity", "C", "", "n..3", "" )]
public string E2152 { get; set; }

    }
}