using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94B.Composites;

namespace underware.Edifact.D94B.Segments
{
    public class FII : Segment
    {
        public FII() : base("FII", "Financial institution information"){}

				[ElementInfo(0, "Party qualifier", "M", "1", "an..3", "" )]
public string E3035 { get; set; }
		[ElementInfo(1, "ACCOUNT IDENTIFICATION", "C", "1", "", "" )]
public C078 C078 { get; set; }
		[ElementInfo(2, "INSTITUTION IDENTIFICATION", "C", "1", "", "" )]
public C088 C088 { get; set; }
		[ElementInfo(3, "Country, coded", "C", "1", "an..3", "" )]
public string E3207 { get; set; }

		
    }
}