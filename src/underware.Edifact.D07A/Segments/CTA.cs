using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class CTA : Segment
    {
        public CTA() : base("CTA", "CONTACT INFORMATION"){}

				[ElementInfo(0, "CONTACT FUNCTION CODE", "Conditional", "", "", "" )]
public string E3139 { get; set; }
		[ElementInfo(1, "CONTACT DETAILS", "Conditional", "", "", "" )]
public C056 C056 { get; set; }

		
    }
}