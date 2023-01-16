using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94A.Composites;

namespace underware.Edifact.D94A.Segments
{
    public class BUS : Segment
    {
        public BUS() : base("BUS", "Business function"){}

				[ElementInfo(0, "BUSINESS FUNCTION", "C", "1", "", "" )]
public C521 C521 { get; set; }
		[ElementInfo(1, "Geographic environment, coded", "C", "1", "an..3", "" )]
public string E3279 { get; set; }
		[ElementInfo(2, "Type of financial transaction, coded", "C", "1", "an..3", "" )]
public string E4487 { get; set; }
		[ElementInfo(3, "BANK OPERATION", "C", "1", "", "" )]
public C551 C551 { get; set; }
		[ElementInfo(4, "Intra-company payment, coded", "C", "1", "an..3", "" )]
public string E4463 { get; set; }

		
    }
}