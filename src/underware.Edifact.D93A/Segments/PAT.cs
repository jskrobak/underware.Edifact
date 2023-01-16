using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D93A.Composites;

namespace underware.Edifact.D93A.Segments
{
    public class PAT : Segment
    {
        public PAT() : base("PAT", "Payment terms basis"){}

				[ElementInfo(0, "Payment terms type qualifier", "M", "1", "an..3", "" )]
public string E4279 { get; set; }
		[ElementInfo(1, "Terms of payment identification", "M", "1", "an..17", "" )]
public string E4277 { get; set; }
		[ElementInfo(2, "TERMS/TIME INFORMATION", "C", "1", "", "" )]
public C112 C112 { get; set; }

		
    }
}