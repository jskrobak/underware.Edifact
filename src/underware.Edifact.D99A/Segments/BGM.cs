using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D99A.Composites;

namespace underware.Edifact.D99A.Segments
{
    public class BGM : Segment
    {
        public BGM() : base("BGM", "Beginning of message"){}

				[ElementInfo(0, "DOCUMENT/MESSAGE NAME", "C", "1", "", "" )]
public C002 C002 { get; set; }
		[ElementInfo(1, "DOCUMENT/MESSAGE IDENTIFICATION", "C", "1", "", "" )]
public C106 C106 { get; set; }
		[ElementInfo(2, "Message function, coded", "C", "1", "an..3", "" )]
public string E1225 { get; set; }
		[ElementInfo(3, "Response type, coded", "C", "1", "an..3", "" )]
public string E4343 { get; set; }

		
    }
}