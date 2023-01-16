using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02A.Composites;

namespace underware.Edifact.D02A.Segments
{
    public class FSQ : Segment
    {
        public FSQ() : base("FSQ", "Formula sequence"){}

				[ElementInfo(0, "Formula sequence code qualifier", "M", "1", "an..3", "" )]
public string E9507 { get; set; }
		[ElementInfo(1, "Formula sequence operand code", "C", "1", "an..17", "" )]
public string E9509 { get; set; }
		[ElementInfo(2, "Sequence position identifier", "C", "1", "an..10", "" )]
public string E1050 { get; set; }
		[ElementInfo(3, "Formula sequence name", "C", "1", "an..35", "" )]
public string E9510 { get; set; }
		[ElementInfo(4, "Free text", "C", "1", "an..512", "" )]
public string E4440 { get; set; }

		
    }
}