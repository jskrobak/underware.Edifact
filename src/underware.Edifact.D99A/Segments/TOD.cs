using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D99A.Composites;

namespace underware.Edifact.D99A.Segments
{
    public class TOD : Segment
    {
        public TOD() : base("TOD", "Terms of delivery or transport"){}

				[ElementInfo(0, "Terms of delivery or transport function, coded", "C", "1", "an..3", "" )]
public string E4055 { get; set; }
		[ElementInfo(1, "Transport charges method of payment, coded", "C", "1", "an..3", "" )]
public string E4215 { get; set; }
		[ElementInfo(2, "TERMS OF DELIVERY OR TRANSPORT", "C", "1", "", "" )]
public C100 C100 { get; set; }

		
    }
}