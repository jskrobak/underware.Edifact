using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04A.Composites;

namespace underware.Edifact.D04A.Segments
{
    public class GPO : Segment
    {
        public GPO() : base("GPO", "Geographical position"){}

				[ElementInfo(0, "Geographical position code qualifier", "M", "1", "an..3", "" )]
public string E6029 { get; set; }
		[ElementInfo(1, "Latitude degree", "C", "1", "an..10", "" )]
public string E6000 { get; set; }
		[ElementInfo(2, "Longitude degree", "C", "1", "an..11", "" )]
public string E6002 { get; set; }
		[ElementInfo(3, "Altitude", "C", "1", "n..18", "" )]
public string E6096 { get; set; }

		
    }
}