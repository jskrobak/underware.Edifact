using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94B.Composites;

namespace underware.Edifact.D94B.Segments
{
    public class COM : Segment
    {
        public COM() : base("COM", "Communication contact"){}

				[ElementInfo(0, "COMMUNICATION CONTACT", "M", "1", "", "" )]
public C076 C076 { get; set; }

		
    }
}