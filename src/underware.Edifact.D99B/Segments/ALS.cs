using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D99B.Composites;

namespace underware.Edifact.D99B.Segments
{
    public class ALS : Segment
    {
        public ALS() : base("ALS", "Additional location information"){}

				[ElementInfo(0, "Location function code qualifier", "M", "1", "an..3", "" )]
public string E3227 { get; set; }
		[ElementInfo(1, "LOCATION", "M", "99", "", "" )]
public E975 E975 { get; set; }

		
    }
}