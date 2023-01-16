using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D99B.Composites;

namespace underware.Edifact.D99B.Segments
{
    public class DNT : Segment
    {
        public DNT() : base("DNT", "Dental information"){}

				[ElementInfo(0, "Object identifier", "C", "1", "an..35", "" )]
public string E7402 { get; set; }
		[ElementInfo(1, "Surface/layer code", "C", "5", "an..3", "" )]
public string E7383 { get; set; }
		[ElementInfo(2, "Cavity zone code", "C", "5", "an..3", "" )]
public string E9647 { get; set; }
		[ElementInfo(3, "Quantity", "C", "6", "an..35", "" )]
public string E6060 { get; set; }
		[ElementInfo(4, "Status description code", "C", "1", "an..3", "" )]
public string E4405 { get; set; }

		
    }
}