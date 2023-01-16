using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D95B.Composites;

namespace underware.Edifact.D95B.Segments
{
    public class ELM : Segment
    {
        public ELM() : base("ELM", "Simple data element details"){}

				[ElementInfo(0, "Simple data element tag", "M", "1", "an..4", "" )]
public string E9150 { get; set; }
		[ElementInfo(1, "Simple data element character representation, coded", "C", "1", "an..3", "" )]
public string E9153 { get; set; }

		
    }
}