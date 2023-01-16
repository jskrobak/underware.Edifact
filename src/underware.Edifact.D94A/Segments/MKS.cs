using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94A.Composites;

namespace underware.Edifact.D94A.Segments
{
    public class MKS : Segment
    {
        public MKS() : base("MKS", "Market/sales channel information"){}

				[ElementInfo(0, "Sector/subject identification qualifier", "M", "1", "an..3", "" )]
public string E7293 { get; set; }
		[ElementInfo(1, "SALES CHANNEL IDENTIFICATION", "M", "1", "", "" )]
public C332 C332 { get; set; }
		[ElementInfo(2, "Action request/notification, coded", "C", "1", "an..3", "" )]
public string E1229 { get; set; }

		
    }
}