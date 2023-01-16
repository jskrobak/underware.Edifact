using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97B.Composites;

namespace underware.Edifact.D97B.Segments
{
    public class DLI : Segment
    {
        public DLI() : base("DLI", "Document line identification"){}

				[ElementInfo(0, "Document line indicator, coded", "M", "1", "an..3", "" )]
public string E1073 { get; set; }
		[ElementInfo(1, "Line item number", "M", "1", "an..6", "" )]
public string E1082 { get; set; }

		
    }
}