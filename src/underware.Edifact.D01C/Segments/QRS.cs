using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01C.Composites;

namespace underware.Edifact.D01C.Segments
{
    public class QRS : Segment
    {
        public QRS() : base("QRS", "Query and response"){}

				[ElementInfo(0, "Sector area identification code qualifier", "M", "1", "an..3", "" )]
public string E7293 { get; set; }
		[ElementInfo(1, "QUESTION DETAILS", "C", "1", "", "" )]
public C811 C811 { get; set; }
		[ElementInfo(2, "RESPONSE DETAILS", "C", "1", "", "" )]
public C812 C812 { get; set; }

		
    }
}