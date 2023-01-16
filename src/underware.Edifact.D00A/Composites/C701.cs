
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00A.Composites
{
    public class C701
    {
				[ElementInfo(0, "Message section code", "C", "", "an..3", "" )]
public string E1049 { get; set; }
		[ElementInfo(1, "Message item identifier", "C", "", "an..35", "" )]
public string E1052 { get; set; }
		[ElementInfo(2, "Message sub-item identifier", "C", "", "n..6", "" )]
public string E1054 { get; set; }

    }
}