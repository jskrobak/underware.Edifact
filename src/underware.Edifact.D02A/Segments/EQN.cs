using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02A.Composites;

namespace underware.Edifact.D02A.Segments
{
    public class EQN : Segment
    {
        public EQN() : base("EQN", "Number of units"){}

				[ElementInfo(0, "NUMBER OF UNIT DETAILS", "M", "1", "", "" )]
public C523 C523 { get; set; }

		
    }
}