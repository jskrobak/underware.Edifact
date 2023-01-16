using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D95A.Composites;

namespace underware.Edifact.D95A.Segments
{
    public class DMS : Segment
    {
        public DMS() : base("DMS", "Document/message summary"){}

				[ElementInfo(0, "Document/message number", "C", "1", "an..35", "" )]
public string E1004 { get; set; }
		[ElementInfo(1, "Document/message name, coded", "C", "1", "an..3", "" )]
public string E1001 { get; set; }
		[ElementInfo(2, "Total number of items", "C", "1", "n..15", "" )]
public string E7240 { get; set; }

		
    }
}