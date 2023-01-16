
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00A.Composites
{
    public class E027
    {
				[ElementInfo(0, "Invoice type code", "M", "", "an..3", "" )]
public string E9631 { get; set; }
		[ElementInfo(1, "Frequency code", "C", "", "an..3", "" )]
public string E2013 { get; set; }

    }
}