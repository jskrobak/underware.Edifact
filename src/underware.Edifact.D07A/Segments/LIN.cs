using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class LIN : Segment
    {
        public LIN() : base("LIN", "LINE ITEM"){}

				[ElementInfo(0, "LINE ITEM IDENTIFIER", "Conditional", "", "", "" )]
public string E1082 { get; set; }
		[ElementInfo(1, "ACTION CODE", "Conditional", "", "", "" )]
public string E1229 { get; set; }
		[ElementInfo(2, "ITEM NUMBER IDENTIFICATION", "Conditional", "", "", "" )]
public C212 C212 { get; set; }
		[ElementInfo(3, "SUB-LINE INFORMATION", "Conditional", "", "", "" )]
public C829 C829 { get; set; }
		[ElementInfo(4, "CONFIGURATION LEVEL NUMBER", "Conditional", "", "", "" )]
public string E1222 { get; set; }
		[ElementInfo(5, "CONFIGURATION OPERATION CODE", "Conditional", "", "", "" )]
public string E7083 { get; set; }

		
    }
}