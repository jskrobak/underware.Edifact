using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D02A.Composites
{
    public class C529
    {
				[ElementInfo(0, "Processing indicator description code", "M", "", "an..3", "" )]
public string E7365 { get; set; }
		[ElementInfo(1, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Process type description code", "C", "", "an..17", "" )]
public string E7187 { get; set; }

    }
}