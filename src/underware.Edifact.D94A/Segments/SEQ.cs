using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94A.Composites;

namespace underware.Edifact.D94A.Segments
{
    public class SEQ : Segment
    {
        public SEQ() : base("SEQ", "Sequence details"){}

				[ElementInfo(0, "Status indicator, coded", "C", "1", "an..3", "" )]
public string E1245 { get; set; }
		[ElementInfo(1, "SEQUENCE INFORMATION", "C", "1", "", "" )]
public C286 C286 { get; set; }

		
    }
}