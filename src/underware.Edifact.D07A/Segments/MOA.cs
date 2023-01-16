using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class MOA : Segment
    {
        public MOA() : base("MOA", "MONETARY AMOUNT"){}

				[ElementInfo(0, "MONETARY AMOUNT", "Mandatory", "", "", "" )]
public C516 C516 { get; set; }

		
    }
}