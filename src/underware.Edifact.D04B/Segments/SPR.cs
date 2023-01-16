using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04B.Composites;

namespace underware.Edifact.D04B.Segments
{
    public class SPR : Segment
    {
        public SPR() : base("SPR", "Organisation classification details"){}

				[ElementInfo(0, "Sector area identification code qualifier", "M", "1", "an..3", "" )]
public string E7293 { get; set; }
		[ElementInfo(1, "Organisation classification code", "C", "1", "an..3", "" )]
public string E3079 { get; set; }
		[ElementInfo(2, "ORGANISATION CLASSIFICATION DETAIL", "C", "1", "", "" )]
public C844 C844 { get; set; }

		
    }
}