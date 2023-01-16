using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class GIR : Segment
    {
        public GIR() : base("GIR", "RELATED IDENTIFICATION NUMBERS"){}

				[ElementInfo(0, "SET TYPE CODE QUALIFIER", "Mandatory", "", "", "" )]
public string E7297 { get; set; }
		[ElementInfo(1, "IDENTIFICATION NUMBER", "Mandatory", "", "", "" )]
public C206 C206 { get; set; }
		[ElementInfo(2, "IDENTIFICATION NUMBER", "Conditional", "", "", "" )]
public C206 C206_0 { get; set; }
		[ElementInfo(3, "IDENTIFICATION NUMBER", "Conditional", "", "", "" )]
public C206 C206_1 { get; set; }
		[ElementInfo(4, "IDENTIFICATION NUMBER", "Conditional", "", "", "" )]
public C206 C206_2 { get; set; }
		[ElementInfo(5, "IDENTIFICATION NUMBER", "Conditional", "", "", "" )]
public C206 C206_3 { get; set; }

		
    }
}