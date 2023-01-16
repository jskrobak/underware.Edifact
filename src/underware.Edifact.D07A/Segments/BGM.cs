using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class BGM : Segment
    {
        public BGM() : base("BGM", "BEGINNING OF MESSAGE"){}

				[ElementInfo(0, "DOCUMENT/MESSAGE NAME", "Conditional", "", "", "" )]
public C002 C002 { get; set; }
		[ElementInfo(1, "DOCUMENT/MESSAGE IDENTIFICATION", "Conditional", "", "", "" )]
public C106 C106 { get; set; }
		[ElementInfo(2, "MESSAGE FUNCTION CODE", "Conditional", "", "", "" )]
public string E1225 { get; set; }
		[ElementInfo(3, "RESPONSE TYPE CODE", "Conditional", "", "", "" )]
public string E4343 { get; set; }

		
    }
}