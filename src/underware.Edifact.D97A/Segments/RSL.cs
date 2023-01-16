using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97A.Composites;

namespace underware.Edifact.D97A.Segments
{
    public class RSL : Segment
    {
        public RSL() : base("RSL", "Result"){}

				[ElementInfo(0, "Result qualifier", "M", "1", "an..3", "" )]
public string E6087 { get; set; }
		[ElementInfo(1, "Result type, coded", "C", "1", "an..3", "" )]
public string E6077 { get; set; }
		[ElementInfo(2, "RESULT DETAILS", "C", "1", "", "" )]
public C831 C831 { get; set; }
		[ElementInfo(3, "RESULT DETAILS", "C", "1", "", "" )]
public C831 C831_0 { get; set; }
		[ElementInfo(4, "MEASUREMENT UNIT DETAILS", "C", "1", "", "" )]
public C848 C848 { get; set; }
		[ElementInfo(5, "Result normalcy indicator, coded", "C", "1", "an..3", "" )]
public string E6079 { get; set; }

		
    }
}