
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00A.Composites
{
    public class E023
    {
				[ElementInfo(0, "Relationship description code", "C", "", "an..3", "" )]
public string E9143 { get; set; }
		[ElementInfo(1, "Gender code", "C", "", "an..3", "" )]
public string E3499 { get; set; }
		[ElementInfo(2, "Employment category description code", "C", "", "an..3", "" )]
public string E9005 { get; set; }
		[ElementInfo(3, "Marital status description code", "C", "", "an..3", "" )]
public string E3479 { get; set; }
		[ElementInfo(4, "Status description code", "C", "", "an..3", "" )]
public string E4405 { get; set; }
		[ElementInfo(5, "Yes or no indicator code", "C", "", "an..3", "" )]
public string E9607 { get; set; }

    }
}