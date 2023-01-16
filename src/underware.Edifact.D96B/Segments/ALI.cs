using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D96B.Composites;

namespace underware.Edifact.D96B.Segments
{
    public class ALI : Segment
    {
        public ALI() : base("ALI", "Additional information"){}

				[ElementInfo(0, "Country of origin, coded", "C", "1", "an..3", "" )]
public string E3239 { get; set; }
		[ElementInfo(1, "Type of duty regime, coded", "C", "1", "an..3", "" )]
public string E9213 { get; set; }
		[ElementInfo(2, "Special conditions, coded", "C", "1", "an..3", "" )]
public string E4183 { get; set; }
		[ElementInfo(3, "Special conditions, coded", "C", "1", "an..3", "" )]
public string E4183_0 { get; set; }
		[ElementInfo(4, "Special conditions, coded", "C", "1", "an..3", "" )]
public string E4183_1 { get; set; }
		[ElementInfo(5, "Special conditions, coded", "C", "1", "an..3", "" )]
public string E4183_2 { get; set; }
		[ElementInfo(6, "Special conditions, coded", "C", "1", "an..3", "" )]
public string E4183_3 { get; set; }

		
    }
}