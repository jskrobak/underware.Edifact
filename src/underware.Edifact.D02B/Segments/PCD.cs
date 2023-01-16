using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02B.Composites;

namespace underware.Edifact.D02B.Segments
{
    public class PCD : Segment
    {
        public PCD() : base("PCD", "Percentage details"){}

				[ElementInfo(0, "PERCENTAGE DETAILS", "M", "1", "", "" )]
public C501 C501 { get; set; }
		[ElementInfo(1, "Status description code", "C", "1", "an..3", "" )]
public string E4405 { get; set; }

		
    }
}