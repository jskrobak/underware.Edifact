using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97A.Composites;

namespace underware.Edifact.D97A.Segments
{
    public class STG : Segment
    {
        public STG() : base("STG", "Stages"){}

				[ElementInfo(0, "Stages qualifier", "M", "1", "an..3", "" )]
public string E9421 { get; set; }
		[ElementInfo(1, "Number of stages", "C", "1", "n..2", "" )]
public string E6426 { get; set; }
		[ElementInfo(2, "Actual stage count", "C", "1", "n..2", "" )]
public string E6428 { get; set; }

		
    }
}