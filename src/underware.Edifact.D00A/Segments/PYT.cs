
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00A.Composites;

namespace underware.Edifact.D00A.Segments
{
    public class PYT : Segment
    {
        public PYT() : base("PYT", "Payment terms"){}

				[ElementInfo(0, "Payment terms type code qualifier", "M", "1", "an..3", "" )]
public string E4279 { get; set; }
		[ElementInfo(1, "PAYMENT TERMS", "C", "1", "", "" )]
public C019 C019 { get; set; }
		[ElementInfo(2, "Time reference code", "C", "1", "an..3", "" )]
public string E2475 { get; set; }
		[ElementInfo(3, "Terms time relation code", "C", "1", "an..3", "" )]
public string E2009 { get; set; }
		[ElementInfo(4, "Period type code", "C", "1", "an..3", "" )]
public string E2151 { get; set; }
		[ElementInfo(5, "Period count quantity", "C", "1", "n..3", "" )]
public string E2152 { get; set; }

		
    }
}