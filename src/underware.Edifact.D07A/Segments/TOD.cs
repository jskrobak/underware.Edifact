using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class TOD : Segment
    {
        public TOD() : base("TOD", "TERMS OF DELIVERY OR TRANSPORT"){}

				[ElementInfo(0, "DELIVERY OR TRANSPORT TERMS FUNCTION CODE", "Conditional", "", "", "" )]
public string E4055 { get; set; }
		[ElementInfo(1, "TRANSPORT CHARGES PAYMENT METHOD CODE", "Conditional", "", "", "" )]
public string E4215 { get; set; }
		[ElementInfo(2, "TERMS OF DELIVERY OR TRANSPORT", "Conditional", "", "", "" )]
public C100 C100 { get; set; }

		
    }
}