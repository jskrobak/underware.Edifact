using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class GIN : Segment
    {
        public GIN() : base("GIN", "GOODS IDENTITY NUMBER"){}

				[ElementInfo(0, "OBJECT IDENTIFICATION CODE QUALIFIER", "Mandatory", "", "", "" )]
public string E7405 { get; set; }
		[ElementInfo(1, "IDENTITY NUMBER RANGE", "Mandatory", "", "", "" )]
public C208 C208 { get; set; }
		[ElementInfo(2, "IDENTITY NUMBER RANGE", "Conditional", "", "", "" )]
public C208 C208_0 { get; set; }
		[ElementInfo(3, "IDENTITY NUMBER RANGE", "Conditional", "", "", "" )]
public C208 C208_1 { get; set; }
		[ElementInfo(4, "IDENTITY NUMBER RANGE", "Conditional", "", "", "" )]
public C208 C208_2 { get; set; }
		[ElementInfo(5, "IDENTITY NUMBER RANGE", "Conditional", "", "", "" )]
public C208 C208_3 { get; set; }

		
    }
}