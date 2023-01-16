using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04B.Composites;

namespace underware.Edifact.D04B.Segments
{
    public class TOD : Segment
    {
        public TOD() : base("TOD", "Terms of delivery or transport"){}

				[ElementInfo(0, "Delivery or transport terms function code", "C", "1", "an..3", "" )]
public string E4055 { get; set; }
		[ElementInfo(1, "Transport charges payment method code", "C", "1", "an..3", "" )]
public string E4215 { get; set; }
		[ElementInfo(2, "TERMS OF DELIVERY OR TRANSPORT", "C", "1", "", "" )]
public C100 C100 { get; set; }

		
    }
}