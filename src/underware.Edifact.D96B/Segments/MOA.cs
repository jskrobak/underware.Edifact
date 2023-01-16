using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D96B.Composites;

namespace underware.Edifact.D96B.Segments
{
    public class MOA : Segment
    {
        public MOA() : base("MOA", "Monetary amount"){}

				[ElementInfo(0, "MONETARY AMOUNT", "M", "1", "", "" )]
public C516 C516 { get; set; }

		
    }
}