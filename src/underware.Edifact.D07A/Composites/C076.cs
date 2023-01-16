using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C076
    {
				[ElementInfo(0, "Communication address identifier", "Mandatory", "", "", "" )]
public string E3148 { get; set; }
		[ElementInfo(1, "Communication means type code", "Mandatory", "", "", "" )]
public string E3155 { get; set; }

    }
}