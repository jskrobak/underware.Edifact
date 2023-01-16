using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02B.Composites;

namespace underware.Edifact.D02B.Segments
{
    public class LIN : Segment
    {
        public LIN() : base("LIN", "Line item"){}

				[ElementInfo(0, "Line item identifier", "C", "1", "an..6", "" )]
public string E1082 { get; set; }
		[ElementInfo(1, "Action request/notification description code", "C", "1", "an..3", "" )]
public string E1229 { get; set; }
		[ElementInfo(2, "ITEM NUMBER IDENTIFICATION", "C", "1", "", "" )]
public C212 C212 { get; set; }
		[ElementInfo(3, "SUB-LINE INFORMATION", "C", "1", "", "" )]
public C829 C829 { get; set; }
		[ElementInfo(4, "Configuration level number", "C", "1", "n..2", "" )]
public string E1222 { get; set; }
		[ElementInfo(5, "Configuration operation code", "C", "1", "an..3", "" )]
public string E7083 { get; set; }

		
    }
}