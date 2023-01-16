using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02A.Composites;

namespace underware.Edifact.D02A.Segments
{
    public class CPT : Segment
    {
        public CPT() : base("CPT", "Account identification"){}

				[ElementInfo(0, "Account type code qualifier", "M", "1", "an..3", "" )]
public string E4437 { get; set; }
		[ElementInfo(1, "ACCOUNT IDENTIFICATION", "M", "1", "", "" )]
public C593 C593 { get; set; }

		
    }
}