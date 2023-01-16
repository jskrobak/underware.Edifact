using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D95A.Composites;

namespace underware.Edifact.D95A.Segments
{
    public class DLM : Segment
    {
        public DLM() : base("DLM", "Delivery limitations"){}

				[ElementInfo(0, "Back order, coded", "C", "1", "an..3", "" )]
public string E4455 { get; set; }
		[ElementInfo(1, "INSTRUCTION", "C", "1", "", "" )]
public C522 C522 { get; set; }
		[ElementInfo(2, "SPECIAL SERVICES IDENTIFICATION", "C", "1", "", "" )]
public C214 C214 { get; set; }
		[ElementInfo(3, "Product/service substitution, coded", "C", "1", "an..3", "" )]
public string E4457 { get; set; }

		
    }
}