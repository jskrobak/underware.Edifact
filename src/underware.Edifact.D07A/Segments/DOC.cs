using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class DOC : Segment
    {
        public DOC() : base("DOC", "DOCUMENT/MESSAGE DETAILS"){}

				[ElementInfo(0, "DOCUMENT/MESSAGE NAME", "Mandatory", "", "", "" )]
public C002 C002 { get; set; }
		[ElementInfo(1, "DOCUMENT/MESSAGE DETAILS", "Conditional", "", "", "" )]
public C503 C503 { get; set; }
		[ElementInfo(2, "COMMUNICATION MEDIUM TYPE CODE", "Conditional", "", "", "" )]
public string E3153 { get; set; }
		[ElementInfo(3, "DOCUMENT COPIES REQUIRED QUANTITY", "Conditional", "", "", "" )]
public string E1220 { get; set; }
		[ElementInfo(4, "DOCUMENT ORIGINALS REQUIRED QUANTITY", "Conditional", "", "", "" )]
public string E1218 { get; set; }

		
    }
}