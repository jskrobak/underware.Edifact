using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98B.Composites;

namespace underware.Edifact.D98B.Segments
{
    public class CMP : Segment
    {
        public CMP() : base("CMP", "Composite data element identification"){}

				[ElementInfo(0, "Composite data element tag", "M", "1", "an..4", "" )]
public string E9146 { get; set; }
		[ElementInfo(1, "Class designator, coded", "C", "1", "an..3", "" )]
public string E1507 { get; set; }
		[ElementInfo(2, "Maintenance operation, coded", "C", "1", "an..3", "" )]
public string E4513 { get; set; }

		
    }
}