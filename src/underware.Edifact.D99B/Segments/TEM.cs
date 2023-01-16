using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D99B.Composites;

namespace underware.Edifact.D99B.Segments
{
    public class TEM : Segment
    {
        public TEM() : base("TEM", "Test method"){}

				[ElementInfo(0, "TEST METHOD", "C", "1", "", "" )]
public C244 C244 { get; set; }
		[ElementInfo(1, "Test route of administering, coded", "C", "1", "an..3", "" )]
public string E4419 { get; set; }
		[ElementInfo(2, "Test medium, coded", "C", "1", "an..3", "" )]
public string E3077 { get; set; }
		[ElementInfo(3, "Measurement attribute code", "C", "1", "an..3", "" )]
public string E6311 { get; set; }
		[ElementInfo(4, "Test revision number", "C", "1", "an..30", "" )]
public string E7188 { get; set; }
		[ElementInfo(5, "TEST REASON", "C", "1", "", "" )]
public C515 C515 { get; set; }

		
    }
}