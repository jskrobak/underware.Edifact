using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C506
    {
				[ElementInfo(0, "Reference code qualifier", "Mandatory", "", "", "" )]
public string E1153 { get; set; }
		[ElementInfo(1, "Reference identifier", "Conditional", "", "", "" )]
public string E1154 { get; set; }
		[ElementInfo(2, "Document line identifier", "Conditional", "", "", "" )]
public string E1156 { get; set; }
		[ElementInfo(3, "Version identifier", "Conditional", "", "", "" )]
public string E1056 { get; set; }
		[ElementInfo(4, "Revision identifier", "Conditional", "", "", "" )]
public string E1060 { get; set; }

    }
}