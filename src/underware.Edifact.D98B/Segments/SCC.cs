using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98B.Composites;

namespace underware.Edifact.D98B.Segments
{
    public class SCC : Segment
    {
        public SCC() : base("SCC", "Scheduling conditions"){}

				[ElementInfo(0, "Delivery plan commitment level, coded", "M", "1", "an..3", "" )]
public string E4017 { get; set; }
		[ElementInfo(1, "Delivery instruction, coded", "C", "1", "an..3", "" )]
public string E4493 { get; set; }
		[ElementInfo(2, "PATTERN DESCRIPTION", "C", "1", "", "" )]
public C329 C329 { get; set; }

		
    }
}