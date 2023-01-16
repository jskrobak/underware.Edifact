using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94B.Composites;

namespace underware.Edifact.D94B.Segments
{
    public class IRQ : Segment
    {
        public IRQ() : base("IRQ", "Information required"){}

				[ElementInfo(0, "INFORMATION REQUEST", "M", "1", "", "" )]
public C333 C333 { get; set; }

		
    }
}