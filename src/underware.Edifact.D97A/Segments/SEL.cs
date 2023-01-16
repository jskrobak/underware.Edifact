using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97A.Composites;

namespace underware.Edifact.D97A.Segments
{
    public class SEL : Segment
    {
        public SEL() : base("SEL", "Seal number"){}

				[ElementInfo(0, "Seal number", "M", "1", "an..10", "" )]
public string E9308 { get; set; }
		[ElementInfo(1, "SEAL ISSUER", "C", "1", "", "" )]
public C215 C215 { get; set; }
		[ElementInfo(2, "Seal condition, coded", "C", "1", "an..3", "" )]
public string E4517 { get; set; }

		
    }
}