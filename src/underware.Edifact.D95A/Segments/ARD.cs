using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D95A.Composites;

namespace underware.Edifact.D95A.Segments
{
    public class ARD : Segment
    {
        public ARD() : base("ARD", "Amounts relationship details"){}

				[ElementInfo(0, "MONETARY FUNCTION", "C", "1", "", "" )]
public C549 C549 { get; set; }

		
    }
}