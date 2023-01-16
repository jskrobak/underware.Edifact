using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D97A.Composites
{
    public class C701
    {
				[ElementInfo(0, "Message section, coded", "C", "", "an..3", "" )]
public string E1049 { get; set; }
		[ElementInfo(1, "Message item number", "C", "", "an..35", "" )]
public string E1052 { get; set; }
		[ElementInfo(2, "Message sub-item number", "C", "", "n..6", "" )]
public string E1054 { get; set; }

    }
}