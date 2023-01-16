
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00A.Composites;

namespace underware.Edifact.D00A.Segments
{
    public class DLI : Segment
    {
        public DLI() : base("DLI", "Document line identification"){}

				[ElementInfo(0, "Document line action code", "M", "1", "an..3", "" )]
public string E1073 { get; set; }
		[ElementInfo(1, "Line item identifier", "M", "1", "an..6", "" )]
public string E1082 { get; set; }

		
    }
}