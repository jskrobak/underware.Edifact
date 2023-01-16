using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94B.Composites;

namespace underware.Edifact.D94B.Segments
{
    public class TOD : Segment
    {
        public TOD() : base("TOD", "Terms of delivery or transport"){}

				[ElementInfo(0, "Terms of delivery or transport function, coded", "C", "1", "an..3", "" )]
public string E4055 { get; set; }

		
    }
}