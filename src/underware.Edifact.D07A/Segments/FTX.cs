using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class FTX : Segment
    {
        public FTX() : base("FTX", "FREE TEXT"){}

				[ElementInfo(0, "TEXT SUBJECT CODE QUALIFIER", "Mandatory", "", "", "" )]
public string E4451 { get; set; }
		[ElementInfo(1, "FREE TEXT FUNCTION CODE", "Conditional", "", "", "" )]
public string E4453 { get; set; }
		[ElementInfo(2, "TEXT REFERENCE", "Conditional", "", "", "" )]
public C107 C107 { get; set; }
		[ElementInfo(3, "TEXT LITERAL", "Conditional", "", "", "" )]
public C108 C108 { get; set; }
		[ElementInfo(4, "LANGUAGE NAME CODE", "Conditional", "", "", "" )]
public string E3453 { get; set; }
		[ElementInfo(5, "FREE TEXT FORMAT CODE", "Conditional", "", "", "" )]
public string E4447 { get; set; }

		
    }
}