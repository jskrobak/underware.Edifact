using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D96A.Composites;

namespace underware.Edifact.D96A.Segments
{
    public class DOC : Segment
    {
        public DOC() : base("DOC", "Document/message details"){}

				[ElementInfo(0, "DOCUMENT/MESSAGE NAME", "M", "1", "", "" )]
public C002 C002 { get; set; }
		[ElementInfo(1, "DOCUMENT/MESSAGE DETAILS", "C", "1", "", "" )]
public C503 C503 { get; set; }
		[ElementInfo(2, "Communication channel identifier, coded", "C", "1", "an..3", "" )]
public string E3153 { get; set; }
		[ElementInfo(3, "Number of copies of document required", "C", "1", "n..2", "" )]
public string E1220 { get; set; }
		[ElementInfo(4, "Number of originals of document required", "C", "1", "n..2", "" )]
public string E1218 { get; set; }

		
    }
}