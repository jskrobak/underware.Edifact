using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98B.Composites;

namespace underware.Edifact.D98B.Segments
{
    public class PAT : Segment
    {
        public PAT() : base("PAT", "Payment terms basis"){}

				[ElementInfo(0, "Payment terms type qualifier", "M", "1", "an..3", "" )]
public string E4279 { get; set; }
		[ElementInfo(1, "PAYMENT TERMS", "C", "1", "", "" )]
public C110 C110 { get; set; }
		[ElementInfo(2, "TERMS/TIME INFORMATION", "C", "1", "", "" )]
public C112 C112 { get; set; }

		
    }
}