using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D93A.Composites;

namespace underware.Edifact.D93A.Segments
{
    public class PIT : Segment
    {
        public PIT() : base("PIT", "Price item line"){}

				[ElementInfo(0, "Line item number", "C", "1", "n..6", "" )]
public string E1082 { get; set; }
		[ElementInfo(1, "Action request/notification, coded", "C", "1", "an..3", "" )]
public string E1229 { get; set; }
		[ElementInfo(2, "PRICE CHANGE INFORMATION", "C", "1", "", "" )]
public C292 C292 { get; set; }
		[ElementInfo(3, "Article availability, coded", "C", "1", "an..3", "" )]
public string E7011 { get; set; }
		[ElementInfo(4, "Sub-line indicator, coded", "C", "1", "an..3", "" )]
public string E5495 { get; set; }
		[ElementInfo(5, "Configuration level", "C", "1", "n..2", "" )]
public string E1222 { get; set; }
		[ElementInfo(6, "Configuration, coded", "C", "1", "an..3", "" )]
public string E7083 { get; set; }

		
    }
}