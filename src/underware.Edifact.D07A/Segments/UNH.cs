using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class UNH : Segment
    {
        public UNH() : base("UNH", "MESSAGE HEADER"){}

				[ElementInfo(0, "MESSAGE REFERENCE NUMBER", "Mandatory", "", "", "" )]
public string E0062 { get; set; }
		[ElementInfo(1, "MESSAGE IDENTIFIER", "Mandatory", "", "", "" )]
public S009 S009 { get; set; }
		[ElementInfo(2, "COMMON ACCESS REFERENCE", "Conditional", "", "", "" )]
public string E0068 { get; set; }
		[ElementInfo(3, "STATUS OF THE TRANSFER", "Conditional", "", "", "" )]
public S010 S010 { get; set; }
		[ElementInfo(4, "MESSAGE SUBSET IDENTIFICATION", "Conditional", "", "", "" )]
public S016 S016 { get; set; }
		[ElementInfo(5, "MESSAGE IMPLEMENTATION GUIDELINE IDENTIFICATION", "Conditional", "", "", "" )]
public S017 S017 { get; set; }
		[ElementInfo(6, "SCENARIO IDENTIFICATION", "Conditional", "", "", "" )]
public S018 S018 { get; set; }

		
    }
}