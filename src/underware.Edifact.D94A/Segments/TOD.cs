using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94A.Composites;

namespace underware.Edifact.D94A.Segments
{
    public class TOD : Segment
    {
        public TOD() : base("TOD", "Terms of delivery"){}

				[ElementInfo(0, "Terms of delivery function, coded", "C", "1", "an..3", "" )]
public string E4055 { get; set; }
		[ElementInfo(1, "Transport charges method of payment, coded", "C", "1", "an..3", "" )]
public string E4215 { get; set; }
		[ElementInfo(2, "TERMS OF DELIVERY", "C", "1", "", "" )]
public C100 C100 { get; set; }

		
    }
}