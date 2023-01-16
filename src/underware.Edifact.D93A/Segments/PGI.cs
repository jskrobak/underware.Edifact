using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D93A.Composites;

namespace underware.Edifact.D93A.Segments
{
    public class PGI : Segment
    {
        public PGI() : base("PGI", "Product group information"){}

				[ElementInfo(0, "Price/tariff type, coded", "M", "1", "an..3", "" )]
public string E5379 { get; set; }
		[ElementInfo(1, "PRICING GROUP", "C", "1", "", "" )]
public C288 C288 { get; set; }

		
    }
}