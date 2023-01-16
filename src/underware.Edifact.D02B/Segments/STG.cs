using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02B.Composites;

namespace underware.Edifact.D02B.Segments
{
    public class STG : Segment
    {
        public STG() : base("STG", "Stages"){}

				[ElementInfo(0, "Process stage code qualifier", "M", "1", "an..3", "" )]
public string E9421 { get; set; }
		[ElementInfo(1, "Process stages quantity", "C", "1", "n..2", "" )]
public string E6426 { get; set; }
		[ElementInfo(2, "Process stages actual quantity", "C", "1", "n..2", "" )]
public string E6428 { get; set; }

		
    }
}