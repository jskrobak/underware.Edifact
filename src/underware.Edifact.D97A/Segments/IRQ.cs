using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97A.Composites;

namespace underware.Edifact.D97A.Segments
{
    public class IRQ : Segment
    {
        public IRQ() : base("IRQ", "Information required"){}

				[ElementInfo(0, "INFORMATION REQUEST", "M", "1", "", "" )]
public C333 C333 { get; set; }

		
    }
}