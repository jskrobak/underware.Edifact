using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04B.Composites;

namespace underware.Edifact.D04B.Segments
{
    public class AUT : Segment
    {
        public AUT() : base("AUT", "Authentication result"){}

				[ElementInfo(0, "Validation result text", "M", "1", "an..35", "" )]
public string E9280 { get; set; }
		[ElementInfo(1, "Validation key identifier", "C", "1", "an..35", "" )]
public string E9282 { get; set; }

		
    }
}