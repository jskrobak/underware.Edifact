using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01C.Composites;

namespace underware.Edifact.D01C.Segments
{
    public class DFN : Segment
    {
        public DFN() : base("DFN", "Definition function"){}

				[ElementInfo(0, "Definition function code", "M", "1", "an..3", "" )]
public string E9023 { get; set; }
		[ElementInfo(1, "Definition extent code", "C", "1", "an..3", "" )]
public string E9025 { get; set; }
		[ElementInfo(2, "Definition identifier", "C", "1", "an..35", "" )]
public string E4519 { get; set; }

		
    }
}