using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03B.Composites;

namespace underware.Edifact.D03B.Segments
{
    public class CIN : Segment
    {
        public CIN() : base("CIN", "Clinical information"){}

				[ElementInfo(0, "Clinical information type code qualifier", "M", "1", "an..3", "" )]
public string E6415 { get; set; }
		[ElementInfo(1, "CLINICAL INFORMATION DETAILS", "C", "1", "", "" )]
public C836 C836 { get; set; }
		[ElementInfo(2, "CERTAINTY DETAILS", "C", "1", "", "" )]
public C837 C837 { get; set; }

		
    }
}