using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D95A.Composites;

namespace underware.Edifact.D95A.Segments
{
    public class STC : Segment
    {
        public STC() : base("STC", "Statistical concept"){}

				[ElementInfo(0, "STATISTICAL CONCEPT IDENTIFICATION", "M", "1", "", "" )]
public C785 C785 { get; set; }
		[ElementInfo(1, "PARTY IDENTIFICATION DETAILS", "C", "1", "", "" )]
public C082 C082 { get; set; }
		[ElementInfo(2, "Status, coded", "C", "1", "an..3", "" )]
public string E4405 { get; set; }
		[ElementInfo(3, "Maintenance operation, coded", "C", "1", "an..3", "" )]
public string E4513 { get; set; }

		
    }
}