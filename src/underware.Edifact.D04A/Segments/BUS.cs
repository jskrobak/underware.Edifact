using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04A.Composites;

namespace underware.Edifact.D04A.Segments
{
    public class BUS : Segment
    {
        public BUS() : base("BUS", "Business function"){}

				[ElementInfo(0, "BUSINESS FUNCTION", "C", "1", "", "" )]
public C521 C521 { get; set; }
		[ElementInfo(1, "Geographic area code", "C", "1", "an..3", "" )]
public string E3279 { get; set; }
		[ElementInfo(2, "Financial transaction type code", "C", "1", "an..3", "" )]
public string E4487 { get; set; }
		[ElementInfo(3, "BANK OPERATION", "C", "1", "", "" )]
public C551 C551 { get; set; }
		[ElementInfo(4, "Intra-company payment indicator code", "C", "1", "an..3", "" )]
public string E4463 { get; set; }

		
    }
}