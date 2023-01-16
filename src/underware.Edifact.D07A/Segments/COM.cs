using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class COM : Segment
    {
        public COM() : base("COM", "COMMUNICATION CONTACT"){}

				[ElementInfo(0, "COMMUNICATION CONTACT", "Mandatory", "", "", "" )]
public C076 C076 { get; set; }

		
    }
}