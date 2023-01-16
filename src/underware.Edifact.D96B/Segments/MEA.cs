using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D96B.Composites;

namespace underware.Edifact.D96B.Segments
{
    public class MEA : Segment
    {
        public MEA() : base("MEA", "Measurements"){}

				[ElementInfo(0, "Measurement application qualifier", "M", "1", "an..3", "" )]
public string E6311 { get; set; }
		[ElementInfo(1, "MEASUREMENT DETAILS", "C", "1", "", "" )]
public C502 C502 { get; set; }
		[ElementInfo(2, "VALUE/RANGE", "C", "1", "", "" )]
public C174 C174 { get; set; }
		[ElementInfo(3, "Surface/layer indicator, coded", "C", "1", "an..3", "" )]
public string E7383 { get; set; }

		
    }
}