using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02A.Composites;

namespace underware.Edifact.D02A.Segments
{
    public class MTD : Segment
    {
        public MTD() : base("MTD", "Maintenance operation details"){}

				[ElementInfo(0, "Object type code qualifier", "M", "1", "an..3", "" )]
public string E7495 { get; set; }
		[ElementInfo(1, "Maintenance operation code", "C", "1", "an..3", "" )]
public string E4513 { get; set; }
		[ElementInfo(2, "Maintenance operation operator code", "C", "1", "an..3", "" )]
public string E3005 { get; set; }
		[ElementInfo(3, "Maintenance operation payer code", "C", "1", "an..3", "" )]
public string E3009 { get; set; }

		
    }
}