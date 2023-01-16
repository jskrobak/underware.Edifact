using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class SEL : Segment
    {
        public SEL() : base("SEL", "SEAL NUMBER"){}

				[ElementInfo(0, "TRANSPORT UNIT SEAL IDENTIFIER", "Conditional", "", "", "" )]
public string E9308 { get; set; }
		[ElementInfo(1, "SEAL ISSUER", "Conditional", "", "", "" )]
public C215 C215 { get; set; }
		[ElementInfo(2, "SEAL CONDITION CODE", "Conditional", "", "", "" )]
public string E4517 { get; set; }
		[ElementInfo(3, "IDENTITY NUMBER RANGE", "Conditional", "", "", "" )]
public C208 C208 { get; set; }
		[ElementInfo(4, "SEAL TYPE CODE", "Conditional", "", "", "" )]
public string E4525 { get; set; }

		
    }
}