using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D96B.Composites;

namespace underware.Edifact.D96B.Segments
{
    public class ARD : Segment
    {
        public ARD() : base("ARD", "Amounts relationship details"){}

				[ElementInfo(0, "MONETARY FUNCTION", "C", "1", "", "" )]
public C549 C549 { get; set; }

		
    }
}