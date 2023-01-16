using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D93A.Composites
{
    public class C531
    {
				[ElementInfo(0, "Packaging level, coded", "C", "", "an..3", "" )]
public string E7075 { get; set; }
		[ElementInfo(1, "Packaging related information, coded", "C", "", "an..3", "" )]
public string E7233 { get; set; }
		[ElementInfo(2, "Packaging terms and conditions, coded", "C", "", "an..3", "" )]
public string E7073 { get; set; }

    }
}