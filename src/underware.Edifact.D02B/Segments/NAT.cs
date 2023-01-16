using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02B.Composites;

namespace underware.Edifact.D02B.Segments
{
    public class NAT : Segment
    {
        public NAT() : base("NAT", "Nationality"){}

				[ElementInfo(0, "Nationality code qualifier", "M", "1", "an..3", "" )]
public string E3493 { get; set; }
		[ElementInfo(1, "NATIONALITY DETAILS", "C", "1", "", "" )]
public C042 C042 { get; set; }

		
    }
}