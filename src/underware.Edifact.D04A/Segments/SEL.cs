using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04A.Composites;

namespace underware.Edifact.D04A.Segments
{
    public class SEL : Segment
    {
        public SEL() : base("SEL", "Seal number"){}

				[ElementInfo(0, "Transport unit seal identifier", "C", "1", "an..35", "" )]
public string E9308 { get; set; }
		[ElementInfo(1, "SEAL ISSUER", "C", "1", "", "" )]
public C215 C215 { get; set; }
		[ElementInfo(2, "Seal condition code", "C", "1", "an..3", "" )]
public string E4517 { get; set; }
		[ElementInfo(3, "IDENTITY NUMBER RANGE", "C", "1", "", "" )]
public C208 C208 { get; set; }

		
    }
}