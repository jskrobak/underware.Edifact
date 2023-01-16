using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D93A.Composites;

namespace underware.Edifact.D93A.Segments
{
    public class EQA : Segment
    {
        public EQA() : base("EQA", "Attached equipment"){}

				[ElementInfo(0, "Equipment qualifier", "M", "1", "an..3", "" )]
public string E8053 { get; set; }
		[ElementInfo(1, "EQUIPMENT IDENTIFICATION", "C", "1", "", "" )]
public C237 C237 { get; set; }

		
    }
}