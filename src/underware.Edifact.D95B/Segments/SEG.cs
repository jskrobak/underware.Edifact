using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D95B.Composites;

namespace underware.Edifact.D95B.Segments
{
    public class SEG : Segment
    {
        public SEG() : base("SEG", "Segment identification"){}

				[ElementInfo(0, "Segment tag", "M", "1", "an..3", "" )]
public string E9166 { get; set; }
		[ElementInfo(1, "Class designator, coded", "C", "1", "an..3", "" )]
public string E1507 { get; set; }
		[ElementInfo(2, "Maintenance operation, coded", "C", "1", "an..3", "" )]
public string E4513 { get; set; }

		
    }
}