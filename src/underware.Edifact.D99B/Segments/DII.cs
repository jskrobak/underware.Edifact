using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D99B.Composites;

namespace underware.Edifact.D99B.Segments
{
    public class DII : Segment
    {
        public DII() : base("DII", "Directory identification"){}

				[ElementInfo(0, "Version", "M", "1", "an..9", "" )]
public string E1056 { get; set; }
		[ElementInfo(1, "Release", "M", "1", "an..9", "" )]
public string E1058 { get; set; }
		[ElementInfo(2, "Directory status", "C", "1", "an..3", "" )]
public string E9148 { get; set; }
		[ElementInfo(3, "Control agency", "C", "1", "an..2", "" )]
public string E1476 { get; set; }
		[ElementInfo(4, "Language name code", "C", "1", "an..3", "" )]
public string E3453 { get; set; }
		[ElementInfo(5, "Maintenance operation, coded", "C", "1", "an..3", "" )]
public string E4513 { get; set; }

		
    }
}