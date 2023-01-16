using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94A.Composites;

namespace underware.Edifact.D94A.Segments
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
		[ElementInfo(3, "Time relation, coded", "C", "1", "an..3", "" )]
public string E2009 { get; set; }
		[ElementInfo(4, "Type of period, coded", "C", "1", "an..3", "" )]
public string E2151 { get; set; }
		[ElementInfo(5, "Number of periods", "C", "1", "n..3", "" )]
public string E2152 { get; set; }

		
    }
}