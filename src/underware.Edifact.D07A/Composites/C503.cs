using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C503
    {
				[ElementInfo(0, "Document identifier", "Conditional", "", "", "" )]
public string E1004 { get; set; }
		[ElementInfo(1, "Document status code", "Conditional", "", "", "" )]
public string E1373 { get; set; }
		[ElementInfo(2, "Document source description", "Conditional", "", "", "" )]
public string E1366 { get; set; }
		[ElementInfo(3, "Language name code", "Conditional", "", "", "" )]
public string E3453 { get; set; }
		[ElementInfo(4, "Version identifier", "Conditional", "", "", "" )]
public string E1056 { get; set; }
		[ElementInfo(5, "Revision identifier", "Conditional", "", "", "" )]
public string E1060 { get; set; }

    }
}